using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KEPIT_Proiznye
{
    public partial class Sum : Form
    {
        int[] nums;
        int[] counts;
        int[] all;
        int[] allC;
        public Sum(int[] nums, int[] counts, int[] all, int[] allC)
        {
            InitializeComponent();
            this.nums = nums;
            this.counts = counts;
            this.all = all;
            this.allC = allC;

            ShowData();

            UpdateSumText(true);
            UpdateSumText(false);
        }
        private void ShowData()
        {
            bezlimit_metro.Text = nums[0].ToString() + " — метро (" + counts[0] + ")";
            bezlimit_metro_avtobus.Text = nums[1].ToString() + " — метро + автобус (" + counts[1] + ")";
            bezlimit_metro_trollejbus.Text = nums[2].ToString() + " — метро + тролейбус (" + counts[2] + ")";
            bezlimit_metro_tramvai.Text = nums[3].ToString() + " — метро + трамвай (" + counts[3] + ")";
            _62_metro.Text = nums[4].ToString() + " — метро (" + counts[4] + ")";
            _62_metro_avtobus.Text = nums[5].ToString() + " — метро + автобус (" + counts[5] + ")";
            _62_metro_trollejbus.Text = nums[6].ToString() + " — метро + тролейбус (" + counts[6] + ")";
            _62_metro_tramvai.Text = nums[7].ToString() + " — метро + трамвай (" + counts[7] + ")";
            _46_metro.Text = nums[8].ToString() + " — метро (" + counts[8] + ")";
            _46_metro_avtobus.Text = nums[9].ToString() + " — метро + автобус (" + counts[9] + ")";
            _46_metro_trollejbus.Text = nums[10].ToString() + " — метро + тролейбус (" + counts[10] + ")";
            _46_metro_tramvai.Text = nums[11].ToString() + " — метро + трамвай (" + counts[11] + ")";
            _1.Text = all[0].ToString() + " — метро (" + allC[0] + ")";
            _2.Text = all[1].ToString() + " — метро + автобус (" + allC[1] + ")";
            _3.Text = all[2].ToString() + " — метро + тролейбус (" + allC[2] + ")";
            _4.Text = all[3].ToString() + " — метро + трамвай (" + allC[3] + ")";
            _5.Text = all[4].ToString() + " — метро (" + allC[4] + ")";
            _6.Text = all[5].ToString() + " — метро + автобус (" + allC[5] + ")";
            _7.Text = all[6].ToString() + " — метро + тролейбус (" + allC[6] + ")";
            _8.Text = all[7].ToString() + " — метро + трамвай (" + allC[7] + ")";
            _9.Text = all[8].ToString() + " — метро (" + allC[8] + ")";
            _10.Text = all[9].ToString() + " — метро + автобус (" + allC[9] + ")";
            _11.Text = all[10].ToString() + " — метро + тролейбус (" + allC[10] + ")";
            _12.Text = all[11].ToString() + " — метро + трамвай (" + allC[11] + ")";
        }
        private void UpdateSumText(bool left)
        {
            int sum = 0;
            if (left)
            {
                if (check_left_bezlimit.Checked) sum += nums[0] + nums[1] + nums[2] + nums[3];
                if (check_left_62.Checked) sum += nums[4] + nums[5] + nums[6] + nums[7];
                if (check_left_46.Checked) sum += nums[8] + nums[9] + nums[10] + nums[11];
                sum_left.Text = sum.ToString();
            }
            else
            {
                if (check_right_bezlimit.Checked) sum += all[0] + all[1] + all[2] + all[3];
                if (check_right_62.Checked) sum += all[4] + all[5] + all[6] + all[7];
                if (check_right_46.Checked) sum += all[8] + all[9] + all[10] + all[11];
                sum_right.Text = sum.ToString();
            }
        }
        private void left_check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSumText(true);
        }

        private void right_check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSumText(false);
        }
    }
}
