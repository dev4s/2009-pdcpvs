using System.Windows.Forms;

namespace PDCPVS
{
    public partial class Pdcpvs
    {
        //Przy pracy z wątkami, jeżeli potrzebujemy coś zaaktualizować na formie z innego wątku
        //niż główny - nasz program wywiesi się, bo nie wie w jakim akuratnie stanie znajduje się
        //dana kontrolka. Dlatego stosuje się delegaty (coś jakby referencje, można też powiedzieć, że
        //delegat jest pośrednikiem).
        //Każda kontrolka posiada metodę Invoke, jak również i właściwość InvokeRequired.
        //Jeżeli jest potrzebne wywołanie do danej kontrolki, to tworzy się egzemplarz delegata
        //razem z metodą, która ma zostać wywołana (można tą samą, można inną, jednak musi
        //ona przyjmować te same wartości) i przez niego przesyła się dane, które chcemy zmodyfikować.
        //Delegat wtedy wywołuje tą metodę już na naszej kontrolce, na wątku, w którym istnieje
        //dana kontrolka

        private delegate void UpdateControlsOnFormEnablePropertyCallBack(bool controlForEnable, int i);
        private void UpdateControlsOnFormEnableProperty(bool controlForEnable, int i)
        {
            if (InvokeRequired)
            {
                var ucofc = new UpdateControlsOnFormEnablePropertyCallBack(UpdateControlsOnFormEnableProperty);
                Invoke(ucofc, controlForEnable, i);
            }
            else
            {
                Controls[i].Enabled = controlForEnable;
            }
        }

        private delegate void UniversalDelegate();
        private void UpdateProgressBarIncrementValue()
        {
            if (InvokeRequired)
            {
                var upbiv = new UniversalDelegate(UpdateProgressBarIncrementValue);
                Invoke(upbiv);
            }
            else
            {
                progressBar.Value++;
            }
        }
        private void UpdateSomeControlsOnMainForm()
        {
            if (InvokeRequired)
            {
                var ud = new UniversalDelegate(UpdateSomeControlsOnMainForm);
                Invoke(ud);
            }
            else
            {
                panelWithProgressBar.Visible = false;
                if (resultBox.Items.Count != 0)
                {
                    resultBox.Enabled = true;
                    buttonDeleteAll.Enabled = true;
                }
            }
        }

        private delegate void UpdateLabelOnFormCallBack(string changeText);
        private void UpdateLabelOnForm(string changeText)
        {
            if (InvokeRequired)
            {
                var ulofc = new UpdateLabelOnFormCallBack(UpdateLabelOnForm);
                Invoke(ulofc, changeText);
            }
            else
            {
                labelInformation.Text = changeText;
            }
        }

        private delegate void UpdateProgressBarStyleCallBack(ProgressBarStyle style);
        private void UpdateProgressBarStyle(ProgressBarStyle style)
        {
            if (InvokeRequired)
            {
                var upbscb = new UpdateProgressBarStyleCallBack(UpdateProgressBarStyle);
                Invoke(upbscb, style);
            }
            else
            {
                progressBar.Style = style;
            }
        }

        private delegate void UpdateProgressBarMaximumValueCallBack(int i);
        private void UpdateProgressBarMaximumValue(int i)
        {
            if (InvokeRequired)
            {
                var upbmvc = new UpdateProgressBarMaximumValueCallBack(UpdateProgressBarMaximumValue);
                Invoke(upbmvc, i);
            }
            else
            {
                progressBar.Maximum = i;
            }
        }

        private delegate void UpdateResultBoxCallBack(string changeText);
        private void UpdateResultBox(string changeText)
        {
            if (InvokeRequired)
            {
                var urbc = new UpdateResultBoxCallBack(UpdateResultBox);
                Invoke(urbc, changeText);
            }
            else
            {
                resultBox.Items.Add(changeText);
            }
        }
    }
}
