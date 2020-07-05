// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Masters
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// SimpleActionTool - SimpleActionTool - Form1.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Windows.Forms;

#endregion

namespace SimpleActionTool
{
    public partial class FrmMain : Form
    {
        private const int MAX_PARAM_LENGTH = 128;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void numType_ValueChanged(object sender, EventArgs e)
        {
            if (numType.Value == 101)
                txtParam.MaxLength = MAX_PARAM_LENGTH * 8;
            else
                txtParam.MaxLength = MAX_PARAM_LENGTH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numId.Minimum = 0;
            numId.Maximum = int.MaxValue;
            numIdNext.Minimum = 0;
            numIdNext.Maximum = int.MaxValue;
            numIdNextFail.Minimum = 0;
            numIdNextFail.Maximum = int.MaxValue;
            numType.Minimum = 0;
            numType.Maximum = short.MaxValue;
            numData.Minimum = 0;
            numData.Maximum = int.MaxValue;
            txtParam.MaxLength = MAX_PARAM_LENGTH;
        }

        private void txtReply0_TextChanged(object sender, EventArgs e)
        {
            if (txtReply0.TextLength > 0)
                cmbReplyType0.SelectedIndex = 0;
            else
                cmbReplyType0.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtReply1.TextLength > 0)
                cmbReplyType1.SelectedIndex = 0;
            else
                cmbReplyType1.SelectedIndex = -1;
        }

        private void txtReply2_TextChanged(object sender, EventArgs e)
        {
            if (txtReply2.TextLength > 0)
                cmbReplyType2.SelectedIndex = 0;
            else
                cmbReplyType2.SelectedIndex = -1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtReply3.TextLength > 0)
                cmbReplyType3.SelectedIndex = 0;
            else
                cmbReplyType3.SelectedIndex = -1;
        }

        private void txtReply4_TextChanged(object sender, EventArgs e)
        {
            if (txtReply4.TextLength > 0)
                cmbReplyType4.SelectedIndex = 0;
            else
                cmbReplyType4.SelectedIndex = -1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtReply5.TextLength > 0)
                cmbReplyType5.SelectedIndex = 0;
            else
                cmbReplyType5.SelectedIndex = -1;
        }

        private void txtReply6_TextChanged(object sender, EventArgs e)
        {
            if (txtReply6.TextLength > 0)
                cmbReplyType6.SelectedIndex = 0;
            else
                cmbReplyType6.SelectedIndex = -1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtReply7.TextLength > 0)
                cmbReplyType7.SelectedIndex = 0;
            else
                cmbReplyType7.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int id = (int) numId.Value;
            int next = (int) numIdNext.Value;
            int fail = (int) numIdNextFail.Value;
            int type = (int) numType.Value;
            int data = (int) numData.Value;
            string param = txtParam.Text;

            if (type == 101 && txtParam.TextLength > MAX_PARAM_LENGTH)
            {
                param = param.Replace(" ", "~");
                int turns = txtParam.TextLength / MAX_PARAM_LENGTH + 1;
                for (int i = 0; i < turns; i++)
                {
                    int max = MAX_PARAM_LENGTH;
                    if (i == turns - 1)
                        max = txtParam.TextLength % MAX_PARAM_LENGTH;

                    string temp = param.Substring(i * MAX_PARAM_LENGTH, Math.Min(128, max));
                    AppendResult(GetQuery(id++, next++, 0, type, data, temp));
                }
            }
            else
            {
                AppendResult(GetQuery(id++, next++, fail, type, data, param));
            }

            if (type == 101)
            {
                for (int i = 0; i < 8; i++)
                {
                    TextBox ctrlReply = Controls.Find($"txtReply{i}", true)[0] as TextBox;
                    ComboBox ctrlType = Controls.Find($"cmbReplyType{i}", true)[0] as ComboBox;

                    if (ctrlReply == null || ctrlType == null)
                        continue;

                    bool last = false;
                    int tempNext = next++;

                    if (i < 7)
                    {
                        TextBox ctrlNextReply = Controls.Find($"txtReply{i + 1}", true)[0] as TextBox;
                        if (string.IsNullOrEmpty(ctrlNextReply?.Text))
                        {
                            last = true;
                            tempNext = int.Parse(cmbFace.Items[Math.Max(0, cmbFace.SelectedIndex)].ToString());
                        }
                    }
                    else
                    {
                        last = true;
                        tempNext = int.Parse(cmbFace.Items[Math.Max(0, cmbFace.SelectedIndex)].ToString());
                    }

                    if (!string.IsNullOrEmpty(ctrlReply.Text))
                    {
                        int thisType = ctrlType.SelectedIndex > 0 ? 103 : 102;
                        string text = ""; //ctrlReply.Text.Replace(" ", "~") + " 0";
                        if (thisType == 103)
                        {
                            string[] split = ctrlReply.Text.Split(new[] {' '}, 3, StringSplitOptions.RemoveEmptyEntries);
                            int length = 16;
                            int task = 0;
                            string description = "";

                            switch (split.Length)
                            {
                                case 1:
                                    description = split[0];
                                    break;
                                case 2:
                                    length = int.Parse(split[0]);
                                    description = split[1].Replace(" ", "~");
                                    break;
                                case 3:
                                    length = int.Parse(split[0]);
                                    task = int.Parse(split[1]);
                                    description = split[2].Replace(" ", "~");
                                    break;
                            }

                            text = string.Concat(length, " ", task, " ", description);
                        }
                        else
                        {
                            text = ctrlReply.Text.Replace(" ", "~") + " 0";
                        }

                        AppendResult(GetQuery(id++, tempNext, 0, thisType, 0, text));
                    }

                    if (last)
                        break;
                }
            }

            numId.Value = id;
            numIdNext.Value = next;
            numIdNextFail.Value = 0;
        }

        private string GetQuery(int id, int next, int fail, int type, int data, string param)
        {
            return $"INSERT INTO `cq_action` VALUES ('{id:0000}', '{next:0000}', '{fail:0000}', '{type:0000}', '{data:0000}', '{param}');";
        }

        private string GetTask(int id)
        {
            return $"INSERT INTO `cq_task` VALUES ('{id:0000}', '{id:0000}', '0000', '', '', '0', '0', '999', '-100000', '100000', '0999', '0000', '0', '-1', '0');";
        }

        private void numId_ValueChanged(object sender, EventArgs e)
        {
            numIdNext.Value = numId.Value + 1;
        }

        private void AppendResult(string result)
        {
            txtResult.AppendText($"{result}\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }
    }
}