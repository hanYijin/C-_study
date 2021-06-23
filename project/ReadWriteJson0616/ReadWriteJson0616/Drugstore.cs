using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteJson0616
{
    class Drugstore
    {


        public string SIGUN_NM { get; set; }//시군명
        public string BIZPLC_NM { get; set; }//사업장면
        public string REFINE_ROADNM_ADDR { get; set; }//소재지(도로명주소)
        public string REFINE_WGS84_LAT { get; set; }//위도
        public string REFINE_WGS84_LOGT { get; set; } //경도
        public string LOCPLC_FACLT_TELNO_DTLS { get; set; }//전화번호
        public string X_CRDNT_VL { get; set; }//x좌표값
        public string Y_CRDNT_VL { get; set; }//y좌표값


        public Drugstore(string sIGUN_NM, string bIZPLC_NM, string rEFINE_ROADNM_ADDR, string rEFINE_WGS84_LAT, string rEFINE_WGS84_LOGT, string lOCPLC_FACLT_TELNO_DTLS, string x_CRDNT_VL, string y_CRDNT_VL)
        {
            SIGUN_NM = sIGUN_NM;
            BIZPLC_NM = bIZPLC_NM;
            REFINE_ROADNM_ADDR = rEFINE_ROADNM_ADDR;
            REFINE_WGS84_LAT = rEFINE_WGS84_LAT;
            REFINE_WGS84_LOGT = rEFINE_WGS84_LOGT;
            LOCPLC_FACLT_TELNO_DTLS = lOCPLC_FACLT_TELNO_DTLS;
            X_CRDNT_VL = x_CRDNT_VL;
            Y_CRDNT_VL = y_CRDNT_VL;
        }



    }
}
