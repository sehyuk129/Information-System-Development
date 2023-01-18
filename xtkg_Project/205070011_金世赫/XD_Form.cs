using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _205070011_金世赫
{
    public partial class XD_Form : Form
    {

        DataSet ds = new DataSet();

        public XD_Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool CheckTalbe = false;

            // DataSet안에 해당하는 DataTable이 있는지 확인 한다
            if (ds.Tables.Contains(cboxClass.Text))
            {
                CheckTalbe = true;
            }


            DataTable dt = null;

            if (!CheckTalbe)  // 기존 Table이 없을 경우 신규로 생성
            {
                dt = new DataTable(cboxClass.Text);

                //DataColumn 생성
                DataColumn colName = new DataColumn("姓名", typeof(string));
                DataColumn colSex = new DataColumn("性别", typeof(string));
                DataColumn colScore = new DataColumn("分数", typeof(string));
                DataColumn colRef = new DataColumn("备注", typeof(string));

                //생성된 Column을 DataTable에 Add
                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colScore);
                dt.Columns.Add(colRef);
            }
            else  // 기존 Table이 있을 경우 기존 Table을 가져온다
            {
                dt = ds.Tables[cboxClass.Text];
            }


            //Row 생성
            DataRow row = dt.NewRow();
            row["姓名"] = tboxName.Text;

            if (rdoFemale.Checked)
            {
                row["性别"] = "女性";
            }
            else if (rdoMale.Checked)
            {
                row["性别"] = "男性";
            }

            row["分数"] = tboxScore.Text;
            row["备注"] = tboxRef.Text;


            //생성된 Row을 DataTable에 Add
            if (CheckTalbe)
            {
                ds.Tables[cboxClass.Text].Rows.Add(row);  // DataSet에 해당 DataTalbe이 있을 경우 기존 Table에 Row를 추가한다
            }
            else
            {
                dt.Rows.Add(row);   // 신규로 작성한 DataTable에 Row를 등록 하고, 
                ds.Tables.Add(dt);  // 등록한 DataTable을 DataSet에 추가한다
            }

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgInfo.SelectedRows[0].Index;  // 선택 한 Row 중에서 첫번째 Row번호를 가져온다
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);   // Table에서 선택한 Row를 삭제 한다

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgInfo.DataSource = ds.Tables[cboxViewClass.Text];


            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
