using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
      dgv.Rows.Add(txtname.Text, txtaddress.Text, txtsal.Text + "$", txtwork.Text, txtskills.Text + "%");
      txtname.Text = "";
      txtaddress.Text = "";
      txtsal.Text = "";
      txtwork.Text = "";
      txtskills.Text = "";
    }

    private void btnedit_Click(object sender, EventArgs e)
    {
      if (dgv.CurrentRow != null)
      {
        dgv.CurrentRow.Cells["name"].Value = txtname.Text;
        dgv.CurrentRow.Cells["address"].Value = txtaddress.Text;
        dgv.CurrentRow.Cells["sal"].Value = txtsal.Text + "$";
        dgv.CurrentRow.Cells["work"].Value = txtwork.Text;
        dgv.CurrentRow.Cells["skills"].Value = txtskills.Text + "%";
      }
    }

    private void btndel_Click(object sender, EventArgs e)
    {
      if (dgv.CurrentRow != null)
      {
        dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
      }
    }

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
      if (dgv.CurrentRow != null)
      {
        txtname.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
        txtaddress.Text=dgv.CurrentRow.Cells["address"].Value.ToString();
        txtsal.Text =dgv.CurrentRow.Cells["sal"].Value.ToString();
        txtwork.Text=dgv.CurrentRow.Cells["work"].Value.ToString();
        txtskills.Text  = dgv.CurrentRow.Cells["skills"].Value.ToString();
      }
    }
  }
}
