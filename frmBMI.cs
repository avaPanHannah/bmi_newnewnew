using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_newnewnew
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpInput_Enter(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 1. 驗證輸入
            bool isHeightValid = double.TryParse(txtHeight.Text, out double height);
            bool isWeightValid = double.TryParse(txtWeight.Text, out double weight);

            if (!isHeightValid || height <= 0 || !isWeightValid || weight <= 0)
            {
                MessageBox.Show("請輸入有效的身高與體重！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. 計算 BMI
            double heightInMeter = height / 100;
            double bmi = weight / (heightInMeter * heightInMeter);
            lblResult.Text = bmi.ToString("F2");

            // 3. 定義：狀態文字、顏色、以及你想要的「建議語」
            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

            // 🌟 這是新增的建議語陣列
            string[] strAdviceList = {
        "提醒：可以多攝取營養，搭配運動增加肌肉量喔！",
        "太棒了！請繼續保持均衡飲食與運動習慣。",
        "注意：開始有點過重囉，建議減少含糖飲料。",
        "警訊：屬於輕度肥胖，建議開始控制熱量攝取。",
        "警告：中度肥胖對健康有風險，建議諮詢營養師。",
        "嚴重警告：重度肥胖會增加心血管疾病風險，請務必就醫檢查。"
    };

            // 4. 判斷 BMI 區間決定 Index
            int index = 0;
            if (bmi < 18.5) index = 0;
            else if (bmi < 24) index = 1;
            else if (bmi < 27) index = 2;
            else if (bmi < 30) index = 3;
            else if (bmi < 35) index = 4;
            else index = 5;

            // 5. 輸出結果
            lblStatus.Text = strResultList[index];
            lblStatus.ForeColor = colorList[index];

            // 🌟 將建議語顯示在 lblAdvice 格子裡
            lblAdvice.Text = strAdviceList[index];
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void pp_Enter(object sender, EventArgs e)
        {

        }
    }
}
