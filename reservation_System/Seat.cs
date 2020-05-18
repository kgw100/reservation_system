using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservation_System
{
    public delegate void Change_SeatCntText(String usedSeatCnt, String nousedSeatCnt);
    class Seat
    {
        public static event Change_SeatCntText change_seatCntText;

        private static int _used_SeatCnt;
        public static int total_SeatCnt{ get; set;}
        public static int used_SeatCnt
        {
            get
            {
                return _used_SeatCnt;
            }
            set
            {
                if (_used_SeatCnt == value)
                { }
                else
                {
                    _used_SeatCnt = value;
                    change_seatCntText(_used_SeatCnt.ToString(),noUsed_SeatCnt.ToString()); // 값 변경마다 라벨 변경하기
                }
            }
        }
        public static int noUsed_SeatCnt
        {
            get
            {
                return total_SeatCnt - used_SeatCnt;
            }
        }
    }
}
