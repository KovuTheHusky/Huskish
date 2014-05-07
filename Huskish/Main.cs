using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Huskish
{
    public partial class Main : Form
    {
        private Random random = new Random();
        private bool keyHandled = false;

        public Main()
        {
            InitializeComponent();
            cboRotate.SelectedIndex = 2;
            cboGarbage.SelectedIndex = 2;
        }

        private void txtString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtString.SelectAll();
                keyHandled = true;
            }
        }

        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHandled)
            {
                e.Handled = true;
                keyHandled = false;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            txtString.Text = GAR(ROT(txtString.Text, (RotationType)cboRotate.SelectedIndex), (GarbageType)cboGarbage.SelectedIndex);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            txtString.Text = ROT(CLN(txtString.Text, (GarbageType)cboGarbage.SelectedIndex), (RotationType)cboRotate.SelectedIndex);
        }

        private string ROT(string str, RotationType typ)
        {
            StringBuilder sb = new StringBuilder();
            switch (typ)
            {
                case RotationType.None:
                    return str;
                case RotationType.ROT5:
                    for (int i = 0; i < str.Length; ++i)
                    {
                        if (str[i] >= '0' && str[i] <= '4')
                            sb.Append((char)((int)str[i] + 5));
                        else if (str[i] >= '5' && str[i] <= '9')
                            sb.Append((char)((int)str[i] - 5));
                        else
                            sb.Append(str[i]);
                    }
                    break;
                case RotationType.ROT13:
                    for (int i = 0; i < str.Length; ++i)
                    {
                        if ((str[i] >= 'a' && str[i] <= 'm') || (str[i] >= 'A' && str[i] <= 'M'))
                            sb.Append((char)((int)str[i] + 13));
                        else if ((str[i] >= 'n' && str[i] <= 'z') || (str[i] >= 'N' && str[i] <= 'Z'))
                            sb.Append((char)((int)str[i] - 13));
                        else
                            sb.Append(str[i]);
                    }
                    break;
                case RotationType.ROT18:
                    for (int i = 0; i < str.Length; ++i)
                    {
                        if (str[i] >= '0' && str[i] <= '4')
                            sb.Append((char)((int)str[i] + 5));
                        else if (str[i] >= '5' && str[i] <= '9')
                            sb.Append((char)((int)str[i] - 5));
                        else if ((str[i] >= 'a' && str[i] <= 'm') || (str[i] >= 'A' && str[i] <= 'M'))
                            sb.Append((char)((int)str[i] + 13));
                        else if ((str[i] >= 'n' && str[i] <= 'z') || (str[i] >= 'N' && str[i] <= 'Z'))
                            sb.Append((char)((int)str[i] - 13));
                        else
                            sb.Append(str[i]);
                    }
                    break;
                case RotationType.ROT47:
                    for (int i = 0; i < str.Length; ++i)
                    {
                        if (str[i] >= '!' && str[i] <= 'O')
                            sb.Append((char)((int)str[i] + 47));
                        else if (str[i] >= 'P' && str[i] <= '~')
                            sb.Append((char)((int)str[i] - 47));
                        else
                            sb.Append(str[i]);
                    }
                    break;
            }
            return sb.ToString();
        }

        private string GAR(string str, GarbageType typ)
        {
            StringBuilder gar = new StringBuilder(), sb = new StringBuilder();
            for (int i = 0; i < str.Length && typ != GarbageType.None; ++i)
                gar.Append((char)random.Next(33, 126));
            switch (typ)
            {
                case GarbageType.None:
                    return str;
                case GarbageType.Prestring:
                    sb.Append(gar.ToString());
                    sb.Append(str);
                    break;
                case GarbageType.Alternate:
                    string tmp = gar.ToString();
                    for (int i = 0; i < str.Length; ++i)
                    {
                        sb.Append(str[i]);
                        sb.Append(tmp[i]);
                    }
                    break;
                case GarbageType.Poststring:
                    sb.Append(str);
                    sb.Append(gar.ToString());
                    break;
            }
            return sb.ToString();
        }

        private string CLN(string str, GarbageType typ)
        {
            StringBuilder sb = new StringBuilder();
            switch (typ)
            {
                case GarbageType.None:
                    return str;
                case GarbageType.Prestring:
                    sb.Append(str.Substring(str.Length / 2));
                    break;
                case GarbageType.Alternate:
                    for (int i = 0; i < str.Length; i += 2)
                        sb.Append(str[i]);
                    break;
                case GarbageType.Poststring:
                    sb.Append(str.Substring(0, str.Length / 2));
                    break;
            }
            return sb.ToString();
        }
    }
}
