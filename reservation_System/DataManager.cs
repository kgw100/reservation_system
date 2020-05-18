using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace reservation_System
{
    class DataManager
    {

        public static List<SeatInfo> seat_List = new List<SeatInfo>();

        public static void Set()
        {
            // 생성된 xml이 없을 경우 생성
            //총 좌석 수가 설정되지 않았으므로, 정해주기
            Seat.total_SeatCnt = 120;
            SeatInfo[] make_Seat = new SeatInfo[Seat.total_SeatCnt];
            seat_List = new List<SeatInfo>(make_Seat);
            //모두 사용가능로 초기화
            for (int pos = 0; pos < Seat.total_SeatCnt; pos++)
            {
                seat_List[pos] = new SeatInfo();
                seat_List[pos].isUsed = false;
            }
        }
        public static void Load(string pickTime)
        {
            try
            {
                string xmlFileName = @"./SeatInfo_" + pickTime + ".xml";
                string seatsOutput = File.ReadAllText(xmlFileName);
                XElement seatsXElement = XElement.Parse(seatsOutput);
                int tempId;
                int tempPos;
                seat_List = (from item in seatsXElement.Descendants("seatInfo")
                             select new SeatInfo()
                             {
                                 name = item.Element("name").Value,
                                 id = int.TryParse(item.Element("id").Value, out tempId) ? int.Parse((item.Element("id").Value)) : (int?)null,
                                 pos = int.TryParse(item.Element("pos").Value, out tempPos) ? int.Parse((item.Element("pos").Value)) : (int?)null,
                                 isUsed = Convert.ToBoolean(item.Element("isUsed").Value)
                             }).ToList<SeatInfo>();
                Seat.total_SeatCnt = seat_List.Count();

            }
            catch (Exception exception)
            { 
                //최초 설정, 모두 사용가능한 상태 
                Set();
                //파일 생성, 최초 생성이므로 오늘날짜로 저장 
                Save(pickTime);
            }

        }
        public static void Save(string pickTime)
        {
            string seatsOutput = "";
            //SeatInfo XML생성 
            seatsOutput += "<seatsInfo>\n";
            foreach (var item in seat_List)
            {
                seatsOutput += "<seatInfo>\n";
                seatsOutput += "  <name>" + item.name + "</name>\n";
                seatsOutput += "  <id>" + item.id + "</id>\n";
                seatsOutput += "  <pos>" + item.pos + "</pos>\n";
                seatsOutput += "  <isUsed>" + item.isUsed + "</isUsed>\n";
                seatsOutput += "</seatInfo>\n";
            }
            seatsOutput += "</seatsInfo>";

            string xmlFileName = @"./SeatInfo_" + pickTime + ".xml";
            //저장
            File.WriteAllText(xmlFileName, seatsOutput);
        }
    }
}
