using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace reservation_System
{
    class SeatBtn
    {
        private static Button focused_btn = null;
        private static List<bool> isUsed { get; set; }
        public static bool btn_FocusCheck(Button cur_btn)
        {
            if (focused_btn == null)
                return false;
            else if (focused_btn == cur_btn)
                return true;
            else //focuused_btn != cur_btn 
                return false;
        }
        public void btn_FocusRegister(Button cur_btn)
        {
            if (focused_btn != cur_btn)
            {
                if (focused_btn != null)
                {
                    int curBtn_num = int.Parse(cur_btn.Text.ToString());
                    int focusBtn_num = int.Parse(focused_btn.Text.ToString());
                    //MessageBox.Show(DataManager.seat_List[curBtn_num-1].isUsed.ToString());
                    // focus 이전의 버튼에 대한 색상 세팅
                    if (DataManager.seat_List[curBtn_num - 1].isUsed)
                        cur_btn.BackColor = Color.FromArgb(250, 204, 204, 204);
                    else
                        cur_btn.BackColor = Color.FromArgb(230, 0, 51, 255);
                    // focus된 버튼에 대한 세팅
                    if (DataManager.seat_List[focusBtn_num - 1].isUsed)
                        focused_btn.BackColor = Color.FromArgb(250, 204, 204, 204);
                    else
                        focused_btn.BackColor = Color.FromArgb(230, 0, 51, 255);
                }
                focused_btn = cur_btn;
            }
        }
        // 좌석버튼이 포커싱됐을 때
        public void newbtn_OnGotFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(230, 255, 204, 0);

        }
        // 좌석버튼이 포커싱을 잃었을때
        public void newbtn_OnLostFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int btn_num = int.Parse(btn.Text);
            bool focus_Check = SeatBtn.btn_FocusCheck(btn);
            if (focus_Check)
            { }
            else
            {
                if (DataManager.seat_List[btn_num - 1].isUsed)
                    btn.BackColor = Color.FromArgb(250, 204, 204, 204); //회색으로 바꾸기
                else
                {
                    btn.BackColor = Color.FromArgb(230, 0, 51, 255); // 파란색으로 바꾸기                
                }
            }
        }
        // hover 기능 구현 
        public void newbtn_MouseMove(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(230, 255, 204, 0);
        }
        public void newbtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int btn_num = int.Parse(btn.Text);
            bool focus_Check = SeatBtn.btn_FocusCheck(btn);
            if (focus_Check)
            { }
            else
            {
                // btn_num보다 seat_List의 인덱스가 1작으므로
                if (DataManager.seat_List[btn_num - 1].isUsed)
                    btn.BackColor = Color.FromArgb(250, 204, 204, 204);
                else
                {
                    btn.BackColor = Color.FromArgb(230, 0, 51, 255);
                }
            }
        }

    }
}
