using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace reservation_System
{
    public partial class MainForm : Form
    {
        Button[] newButton;

        public MainForm()
        {
            //Xml Data 불러오기
            DataManager.Load();
            //UI를 미리 그리기전에 등록을 해두어야함 
            Seat.change_seatCntText += new Change_SeatCntText(set_UsedSeatCnt);
            InitializeComponent();
            //버튼 리스트 객체 생성 
            newButton = new Button[Seat.total_SeatCnt];
            //좌석현황 버튼만들기
            Thread thread_makeBtn = new Thread(Thread_MakeBtn);
            thread_makeBtn.Start();
            //데이터 그리드 뷰에 데이터 랜더링 
            dgvResSts_Load();
            // 사용중인 좌석 구하기
            Seat.used_SeatCnt = DataManager.seat_List.Where((x) => x.isUsed == true).Count();
            //전체 독서실 좌석수 등록
            totalCount.Text = Seat.total_SeatCnt.ToString();
            usedCount.Text = Seat.used_SeatCnt.ToString();
            noUsedCount.Text = Seat.noUsed_SeatCnt.ToString();
        }
        //좌석 수 현황 반영하기
        private void set_UsedSeatCnt(string usedSeatCnt, string noUsedSeatCnt)
        {
            usedCount.Text = usedSeatCnt;
            noUsedCount.Text = noUsedSeatCnt;
        }
        // 좌석현황 버튼 처리 
        private void make_Btn()
        {
            SeatBtn seatBtn = new SeatBtn();
            for (int num = 0; num < Seat.total_SeatCnt; num++)
            {
                // 리스트안 각각 배열하나마다 객체를 또 생성해줘야 오류가 나지않는다.
                newButton[num] = new Button();
                newButton[num].Text = (num + 1).ToString();//num이 0부터 시작하기때문에
                newButton[num].Name = "seat" + (num + 1).ToString();
                newButton[num].Click += new EventHandler(newbtn_Click);
                newButton[num].GotFocus += new EventHandler(seatBtn.newbtn_OnGotFocus);
                newButton[num].LostFocus += new EventHandler(seatBtn.newbtn_OnLostFocus);
                newButton[num].MouseMove += new System.Windows.Forms.MouseEventHandler(seatBtn.newbtn_MouseMove);
                newButton[num].MouseLeave += new EventHandler(seatBtn.newbtn_MouseLeave);
                newButton[num].Size = new Size(37, 37);
                newButton[num].Font = new Font("맑은 고딕", 9, FontStyle.Bold);
                newButton[num].ForeColor = Color.White;
                //num+1에 해당하는 위치의 좌석 정보 불러오기 
                SeatInfo seat = DataManager.seat_List[num];
                //사용 가능, 사용중 버튼 색을 다르게 세팅
                if (seat.isUsed == false)
                    newButton[num].BackColor = Color.FromArgb(230, 0, 51, 255);
                else
                    newButton[num].BackColor = Color.FromArgb(250, 204, 204, 204);
                //newButton[num].BackColor = Color.FromArgb(230, 0, 51, 255);
                // 버튼 동적 생성 
                int btn_Row = num; // 행 번호, 첫 줄은 세로로 이동시키지 않기 위해 1을 뺌 
                int btn_ColumnCnt = 20; // 한 줄당 버튼 개수
                int btn_distance = 40;// 버튼 간격 
                if (num < btn_ColumnCnt)
                    // 1로할경우는 num-1를 해줘야하지만  num이 0인 경우는 알아서 처리된다.
                    // num -1를 한 이유는 행에서 가장 첫번째 버튼은 고정으로 하기위해
                    // 7은 가장자리랑 떨어지기위해 더해준값, 
                    newButton[num].Location = new Point(7 + btn_distance * (num), (btn_Row / btn_ColumnCnt) * btn_distance);
                else
                    newButton[num].Location = new Point(7 + btn_distance * (num - (btn_ColumnCnt * (btn_Row / btn_ColumnCnt))), (btn_Row / btn_ColumnCnt) * btn_distance);

                seatList.Controls.Add(newButton[num]);
            }
        }
        // 좌석 버튼 클릭시
        void newbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int btn_num = int.Parse(btn.Text);
            SeatBtn seatBtn = new SeatBtn();
            seatBtn.btn_FocusRegister(btn);
            SeatInfo cur_seat = DataManager.seat_List[btn_num - 1];
            btn.BackColor = Color.FromArgb(230, 255, 204, 0); // 노란색으로 바꾸기 

            if (cur_seat.isUsed)
            {
                tb_id.Text = cur_seat.id.ToString();
                tb_name.Text = cur_seat.name;
                //readOnly로 설정
                tb_id.ReadOnly = true;
                tb_name.ReadOnly = true;
            }
            else
            {
                tb_id.ReadOnly = false;
                tb_name.ReadOnly = false;
                tb_id.Clear();
                tb_name.Clear();
            }
            tb_pos.Text = btn.Text;
        }
        //예약버튼 처리 부분 
        private void reservBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Button reservBtn = sender as Button;
                if (reservBtn == null)
                    MessageBox.Show("예약버튼에 오류가 발생했습니다.");
                int? pos = int.Parse(tb_pos.Text);

                //pos 체크
                if (pos == null)
                {
                    MessageBox.Show("좌석번호가 입력되지않았습니다. 좌석버튼을 클릭하세요.");
                    return;
                }
                int btn_num = pos.Value;
                if (DataManager.seat_List[btn_num - 1].isUsed)
                    UsedBtn_Click();
                else
                {
                    noUsedBtn_Click(btn_num);
                    DataManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // 사용 중인 좌석버튼 클릭 
        private void UsedBtn_Click()
        {
            MessageBox.Show("현재 사용중인 좌석입니다.");
        }
        //사용 가능한 좌석버튼 클릭
        private void noUsedBtn_Click(int btn_num)
        {
            int? id = int.Parse(tb_id.Text);
            string name = tb_name.Text;
            //id 체크
            if (id == null)
            {
                MessageBox.Show("학번이 입력되지않았습니다. 다시 입력하세요.");
                return;
            }
            //이름체크
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름이 입력되지않았습니다. 다시 입력하세요.");
                return;
            }
            try
            {
                for (int i = 0; i < dgvResSts.Rows.Count; i++)
                {

                    if (Equals(dgvResSts.Rows[i].Cells[0].Value, id))
                    {
                        MessageBox.Show("이미 동일한 학번이 사용중입니다. 다시 입력하세요.");
                        return;
                    }
                    Thread.Sleep(5);
                }
                SeatInfo tempSeatUser = new SeatInfo() { id = id, name = name, pos = btn_num, isUsed = true };
                dgvResSts.Rows.Add(tempSeatUser.id, tempSeatUser.name, tempSeatUser.pos);
                DataManager.seat_List[btn_num - 1] = tempSeatUser;
                newButton[btn_num - 1].BackColor = Color.FromArgb(250, 204, 204, 204);
                Seat.used_SeatCnt += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {   //입력했던것들 비우기
                tb_id.Clear();
                tb_name.Clear();
            }
        }
        // 학번은 숫자만 입력가능하도록 
        private void tbID_Check(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
                MessageBox.Show("학번은 숫자만 입력가능합니다.");
            }
        }
        // 이름은 문자만 입력가능하도록 
        private void tbName_Check(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            { }
            else
            {
                e.Handled = true;
                MessageBox.Show("이름은 문자만 입력가능합니다.");
            }
        }
        // DataGridview에 예약 현황 불러오기 
        private void dgvResSts_Load()
        {
            foreach (SeatInfo seatData in DataManager.seat_List)
            {
                if (seatData.isUsed)
                {
                    dgvResSts.Rows.Add(seatData.id, seatData.name, seatData.pos);
                }
            }
        }
        //종료 버튼 
        private void cls_btn_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(tb_pos.Text);
            bool isUsed = DataManager.seat_List[pos - 1].isUsed;
            // 비어있는 좌석 체크
            if (!isUsed)
            {
                MessageBox.Show("비어있는 좌석입니다.");
                return;
            }
            foreach (DataGridViewRow row in dgvResSts.Rows)
            {
                if (Equals(row.Cells[0].Value.ToString(), tb_id.Text))
                {
                    //사용 종료를 묻는 확인창 
                    if (MessageBox.Show("사용을 종료하시겠습니까?",
                        "사용종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataManager.seat_List[pos - 1].id = null;
                        DataManager.seat_List[pos - 1].name = "";
                        DataManager.seat_List[pos - 1].pos = null;
                        DataManager.seat_List[pos - 1].isUsed = false;
                        Seat.used_SeatCnt -= 1;
                        //삭제하려는 좌석의 학생ID에 해당하는 ROW 삭제 
                        dgvResSts.Rows.Remove(row);
                        //변경사항 저장 
                        DataManager.Save();
                        //텍스트 칸 비우기 
                        tb_id.Clear();
                        tb_name.Clear();
                        tb_pos.Clear();
                    }
                }
            }
        }
        //makBtn부분을 스레드로 처리하기 
        private void Thread_MakeBtn()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    make_Btn();
                }));
            }
            else
                make_Btn();
        }
    }

}
