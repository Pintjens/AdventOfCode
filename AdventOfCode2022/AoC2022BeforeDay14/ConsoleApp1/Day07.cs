using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day07
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1Try3();
            }
            else if (choice == "2")
            {
                Part2();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public static void Fail()
        {
            string[,] dataSet = { { "€", " / " }, { "$", "ls" }, { "dir", "dcvzbqf" }, { "23804", "gsdpmrq.bsz" }, { "24936", "nfngbl.mcn" }, { "178747", "plw.frm" }, { "dir", "qdtw" }, { "dir", "qmfvph" }, { "€", "dcvzbqf" }, { "$", "ls" }, { "dir", "gfvl" }, { "€", "gfvl" }, { "$", "ls" }, { "104564", "dnbmm.bgc" }, { "€", ".." }, { "€", ".." }, { "€", "qdtw" }, { "$", "ls" }, { "dir", "fsj" }, { "dir", "jwfbvmds" }, { "216592", "pcg.wnr" }, { "dir", "pwnhpm" }, { "dir", "qbrpq" }, { "dir", "wdc" }, { "dir", "wpw" }, { "dir", "zbfgmw" }, { "€", "fsj" }, { "$", "ls" }, { "118575", "ltbr.mdf" }, { "€", ".." }, { "€", "jwfbvmds" }, { "$", "ls" }, { "dir", "bbvg" }, { "dir", "bds" }, { "dir", "clvljpb" }, { "44460", "gwbbbgj.hbs" }, { "dir", "hzqlb" }, { "dir", "jpvnzhf" }, { "61025", "trdm.qps" }, { "€", "bbvg" }, { "$", "ls" }, { "219031", "zbzgvsb" }, { "94339", "zhfmsb.lvv" }, { "€", ".." }, { "€", "bds" }, { "$", "ls" }, { "133483", "hzqlb" }, { "€", ".." }, { "€", "clvljpb" }, { "$", "ls" }, { "103511", "bmm.dwc" }, { "121211", "clvljpb.fzn" }, { "158145", "dnbmm.fmm" }, { "74998", "pcg.wnr" }, { "dir", "psvtz" }, { "€", "psvtz" }, { "$", "ls" }, { "dir", "gdj" }, { "167697", "pcgjgc.wgl" }, { "2613", "qchfgv" }, { "91712", "qsdzj.jng" }, { "€", "gdj" }, { "$", "ls" }, { "133897", "qchfgv" }, { "dir", "vmcshh" }, { "93805", "zgmvb.jfg" }, { "€", "vmcshh" }, { "$", "ls" }, { "200517", "zgwwvb.pcs" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "dnbmm" }, { "€", "dnbmm" }, { "$", "ls" }, { "223576", "msrbz.wjs" }, { "€", ".." }, { "€", ".." }, { "€", "jpvnzhf" }, { "$", "ls" }, { "20581", "nfngbl.mcn" }, { "€", ".." }, { "€", ".." }, { "€", "pwnhpm" }, { "$", "ls" }, { "dir", "clvljpb" }, { "33727", "hzqlb.zpp" }, { "39037", "lfjjf.pjt" }, { "163662", "mbwfhq.cjj" }, { "236292", "nfngbl.mcn" }, { "189576", "zvbgnbvf" }, { "€", "clvljpb" }, { "$", "ls" }, { "dir", "clvljpb" }, { "212906", "clvljpb.pls" }, { "214564", "dnm" }, { "dir", "fvgbsft" }, { "230034", "hzqlb.jvz" }, { "48101", "plw.frm" }, { "237902", "qchfgv" }, { "€", "clvljpb" }, { "$", "ls" }, { "dir", "hzqlb" }, { "dir", "zhq" }, { "€", "hzqlb" }, { "$", "ls" }, { "189238", "cvgp" }, { "dir", "gjg" }, { "€", "gjg" }, { "$", "ls" }, { "167082", "ttltfz.bvz" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "203202", "nfngbl.mcn" }, { "212148", "qhnnr.dhs" }, { "€", ".." }, { "€", ".." }, { "€", "fvgbsft" }, { "$", "ls" }, { "dir", "fzhwsjf" }, { "18477", "nps" }, { "dir", "vlplrn" }, { "dir", "vnbg" }, { "dir", "vpc" }, { "€", "fzhwsjf" }, { "$", "ls" }, { "91220", "clvljpb.png" }, { "235721", "pcg.wnr" }, { "61559", "qchfgv" }, { "70762", "vpr.nlc" }, { "€", ".." }, { "€", "vlplrn" }, { "$", "ls" }, { "260247", "qrtnfmln.tpv" }, { "€", ".." }, { "€", "vnbg" }, { "$", "ls" }, { "43069", "ttltfz.mzr" }, { "dir", "wfb" }, { "58219", "zgwwvb.pcs" }, { "272132", "zhq.mrw" }, { "€", "wfb" }, { "$", "ls" }, { "107068", "clvljpb.mtp" }, { "€", ".." }, { "€", ".." }, { "€", "vpc" }, { "$", "ls" }, { "185602", "dnbmm.hfm" }, { "100399", "hzqlb.vtn" }, { "259486", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "qbrpq" }, { "$", "ls" }, { "138169", "cntvzqfm.hgp" }, { "216598", "dnbmm.lhs" }, { "116696", "nfngbl.mcn" }, { "35315", "phf.rvn" }, { "€", ".." }, { "€", "wdc" }, { "$", "ls" }, { "270492", "ghdzdq.ghg" }, { "137119", "lnt.nsd" }, { "€", ".." }, { "€", "wpw" }, { "$", "ls" }, { "dir", "dnbmm" }, { "156266", "jgfv.cpp" }, { "156947", "lvlqcrrs.djl" }, { "dir", "lvznwbpg" }, { "12199", "nfngbl.mcn" }, { "54105", "nlsp" }, { "86737", "zhq.wmz" }, { "€", "dnbmm" }, { "$", "ls" }, { "138125", "lth.hcq" }, { "80844", "nhh.gzc" }, { "149596", "ttltfz.ntn" }, { "€", ".." }, { "€", "lvznwbpg" }, { "$", "ls" }, { "99156", "ldtst.dcr" }, { "217350", "pcg.wnr" }, { "247238", "plw.frm" }, { "dir", "qbqpsccr" }, { "dir", "wnms" }, { "dir", "zhq" }, { "165426", "zmhnzdmb.jnc" }, { "€", "qbqpsccr" }, { "$", "ls" }, { "272199", "pcg.wnr" }, { "219600", "wpjqjm.qwr" }, { "257473", "zhq.zmq" }, { "€", ".." }, { "€", "wnms" }, { "$", "ls" }, { "dir", "ttltfz" }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "btm" }, { "€", "btm" }, { "$", "ls" }, { "dir", "hzqlb" }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "ttltfz" }, { "€", "ttltfz" }, { "$", "ls" }, { "204980", "hzqlb.hhm" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "154868", "srdfz" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zbfgmw" }, { "$", "ls" }, { "dir", "fcjwpgz" }, { "dir", "ttltfz" }, { "dir", "zhq" }, { "€", "fcjwpgz" }, { "$", "ls" }, { "dir", "jltvg" }, { "9958", "qchfgv" }, { "dir", "wwqrb" }, { "€", "jltvg" }, { "$", "ls" }, { "6370", "bssvrjdq.mnr" }, { "€", ".." }, { "€", "wwqrb" }, { "$", "ls" }, { "157805", "npdl" }, { "237057", "qchfgv" }, { "dir", "twrp" }, { "259572", "vptsgw" }, { "176388", "zgwwvb.pcs" }, { "91956", "zhq" }, { "€", "twrp" }, { "$", "ls" }, { "dir", "sfvntjwf" }, { "€", "sfvntjwf" }, { "$", "ls" }, { "68331", "hdwfg.jrl" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "41183", "plw.frm" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "32950", "dmzbmrdr.gtq" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "195502", "dmgmwbf" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "qmfvph" }, { "$", "ls" }, { "dir", "cwfh" }, { "dir", "dnbmm" }, { "dir", "mmmdpth" }, { "4841", "pcg.wnr" }, { "dir", "prnpbn" }, { "111478", "sgmg.hbs" }, { "dir", "ttltfz" }, { "178296", "ttltfz.mjc" }, { "dir", "zcvfqn" }, { "dir", "zhq" }, { "32446", "zhq.pjm" }, { "dir", "zpb" }, { "€", "cwfh" }, { "$", "ls" }, { "dir", "dswtm" }, { "dir", "mwzjf" }, { "€", "dswtm" }, { "$", "ls" }, { "70390", "fmq.mrp" }, { "108185", "qjlfnlp" }, { "189923", "zhq.njc" }, { "€", ".." }, { "€", "mwzjf" }, { "$", "ls" }, { "122536", "glmpd.mdl" }, { "108226", "nfngbl.mcn" }, { "dir", "qbvffr" }, { "33192", "ttltfz" }, { "195824", "zgwwvb.pcs" }, { "€", "qbvffr" }, { "$", "ls" }, { "147595", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "dnbmm" }, { "$", "ls" }, { "dir", "cbdl" }, { "dir", "fhqjzf" }, { "56752", "gsgrnf.mlt" }, { "dir", "ndp" }, { "67967", "nfngbl.mcn" }, { "dir", "swgwdv" }, { "€", "cbdl" }, { "$", "ls" }, { "263964", "dnrbtr.lbh" }, { "66120", "qchfgv" }, { "dir", "qwvd" }, { "€", "qwvd" }, { "$", "ls" }, { "dir", "dnbmm" }, { "143315", "mhlswpcd.lpt" }, { "199969", "ncdrrp.ljf" }, { "€", "dnbmm" }, { "$", "ls" }, { "122474", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "fhqjzf" }, { "$", "ls" }, { "dir", "fnnbrlc" }, { "dir", "hzqlb" }, { "254128", "pcg.wnr" }, { "168008", "plw.frm" }, { "dir", "vwgvd" }, { "dir", "zhq" }, { "€", "fnnbrlc" }, { "$", "ls" }, { "156413", "dnbmm.ngb" }, { "30790", "zbfnjnnz.csg" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "267451", "cgzrdpr" }, { "77460", "nfngbl.mcn" }, { "205978", "plw.frm" }, { "66224", "sjw.ctb" }, { "212873", "zgwwvb.pcs" }, { "€", ".." }, { "€", "vwgvd" }, { "$", "ls" }, { "161177", "phdbz.tmc" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "dir", "hchlgv" }, { "218946", "rfngrlz.zzr" }, { "dir", "zhq" }, { "€", "hchlgv" }, { "$", "ls" }, { "dir", "dnbmm" }, { "270943", "hcpnwbd" }, { "dir", "hzqlb" }, { "13433", "wdljw.cgn" }, { "€", "dnbmm" }, { "$", "ls" }, { "150415", "pcg.wnr" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "44475", "qcvwtfg.wrl" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "155076", "ggndpjzp.rpz" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ndp" }, { "$", "ls" }, { "112146", "nfw.htp" }, { "207815", "vqwtw.qff" }, { "€", ".." }, { "€", "swgwdv" }, { "$", "ls" }, { "dir", "dmqn" }, { "dir", "fzgdjp" }, { "205897", "hzqlb.vtm" }, { "226944", "nfngbl.mcn" }, { "259443", "nrfpz.vmn" }, { "136591", "zgwwvb.pcs" }, { "€", "dmqn" }, { "$", "ls" }, { "258693", "gdplrzt.wzf" }, { "141489", "hzqlb" }, { "225488", "pghz.brw" }, { "€", ".." }, { "€", "fzgdjp" }, { "$", "ls" }, { "206026", "msthjppp" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "mmmdpth" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "hzqlb" }, { "263747", "pcg.wnr" }, { "€", "clvljpb" }, { "$", "ls" }, { "168342", "qhgndmj" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "lqvgqhw" }, { "€", "lqvgqhw" }, { "$", "ls" }, { "218324", "swnjhbj.cqt" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "prnpbn" }, { "$", "ls" }, { "dir", "dndnhn" }, { "176959", "gzhtvt" }, { "85765", "hzqlb.clg" }, { "120691", "nfngbl.mcn" }, { "245942", "qchfgv" }, { "43951", "zgwwvb.pcs" }, { "€", "dndnhn" }, { "$", "ls" }, { "235760", "dhvvnqpt" }, { "dir", "hvg" }, { "dir", "jqvmzg" }, { "dir", "mhz" }, { "€", "hvg" }, { "$", "ls" }, { "167698", "zqbj" }, { "€", ".." }, { "€", "jqvmzg" }, { "$", "ls" }, { "218904", "wppv.mqz" }, { "dir", "zlp" }, { "€", "zlp" }, { "$", "ls" }, { "8030", "wvj.gld" }, { "€", ".." }, { "€", ".." }, { "€", "mhz" }, { "$", "ls" }, { "37541", "tdfvwqlj" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "dnbmm" }, { "dir", "ttltfz" }, { "dir", "wbvcf" }, { "dir", "wsqvpp" }, { "148645", "zgwwvb.pcs" }, { "€", "dnbmm" }, { "$", "ls" }, { "116852", "mjzgll.bcp" }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "hzqlb" }, { "dir", "msczpj" }, { "dir", "mvbhn" }, { "38087", "nfngbl.mcn" }, { "dir", "ttjbnj" }, { "dir", "ttltfz" }, { "dir", "vjj" }, { "dir", "zhq" }, { "dir", "zqgcbnrt" }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "jshj" }, { "dir", "jtjv" }, { "dir", "mgfwthq" }, { "dir", "zhq" }, { "€", "jshj" }, { "$", "ls" }, { "235605", "cldpdjp.cbc" }, { "dir", "clvljpb" }, { "dir", "dzcnm" }, { "dir", "hmvw" }, { "dir", "hzqlb" }, { "dir", "ltpqhg" }, { "12951", "qchfgv" }, { "dir", "wzvjft" }, { "€", "clvljpb" }, { "$", "ls" }, { "65802", "lnpjlj" }, { "25402", "qrtrvmwl.fms" }, { "€", ".." }, { "€", "dzcnm" }, { "$", "ls" }, { "dir", "cpnwcv" }, { "dir", "hzqlb" }, { "dir", "mjclcntf" }, { "dir", "qnljb" }, { "237105", "rlpvq.fbf" }, { "dir", "zhq" }, { "€", "cpnwcv" }, { "$", "ls" }, { "27600", "qbgclqc.tdd" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "168016", "zhq" }, { "€", ".." }, { "€", "mjclcntf" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "qpjtr" }, { "43145", "zgwwvb.pcs" }, { "€", "clvljpb" }, { "$", "ls" }, { "15025", "plw.frm" }, { "€", ".." }, { "€", "qpjtr" }, { "$", "ls" }, { "54909", "zhq" }, { "€", ".." }, { "€", ".." }, { "€", "qnljb" }, { "$", "ls" }, { "49366", "clvljpb.vtg" }, { "52193", "fnd.tfr" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "105765", "dfnqhggg.cfj" }, { "dir", "hfzgs" }, { "135556", "spff" }, { "129957", "vzgjrc.cbs" }, { "€", "hfzgs" }, { "$", "ls" }, { "52456", "ttltfz.fdq" }, { "31345", "wcmf.hsd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hmvw" }, { "$", "ls" }, { "77175", "flhlwq.rqc" }, { "dir", "gmvqz" }, { "252279", "gnmvm" }, { "dir", "lmbqfhb" }, { "€", "gmvqz" }, { "$", "ls" }, { "129431", "dnbmm.lwl" }, { "€", ".." }, { "€", "lmbqfhb" }, { "$", "ls" }, { "dir", "wjql" }, { "€", "wjql" }, { "$", "ls" }, { "48687", "cgtbqqq.zzs" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "105333", "mqsgqph" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "116802", "hbtlhjn.dvs" }, { "8842", "pcg.wnr" }, { "211096", "plw.frm" }, { "€", ".." }, { "€", ".." }, { "€", "ltpqhg" }, { "$", "ls" }, { "245821", "hchndjgj.vht" }, { "229181", "rcfmhrqm.ftc" }, { "214977", "vgdsjg.jpd" }, { "124547", "zgwwvb.pcs" }, { "€", ".." }, { "€", "wzvjft" }, { "$", "ls" }, { "dir", "fdntdf" }, { "174465", "pcg.wnr" }, { "80888", "qchfgv" }, { "82987", "rqbzbrlv" }, { "€", "fdntdf" }, { "$", "ls" }, { "79808", "cmlt.cvd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "jtjv" }, { "$", "ls" }, { "262350", "zww.fbl" }, { "€", ".." }, { "€", "mgfwthq" }, { "$", "ls" }, { "32365", "gjq.rpz" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "dfdbzzz" }, { "dir", "lqhfbp" }, { "152633", "nfngbl.mcn" }, { "€", "clvljpb" }, { "$", "ls" }, { "72966", "scs" }, { "€", ".." }, { "€", "dfdbzzz" }, { "$", "ls" }, { "206453", "cgrdn.dcw" }, { "€", ".." }, { "€", "lqhfbp" }, { "$", "ls" }, { "141515", "nlvswpcm.fvm" }, { "68018", "zgwwvb.pcs" }, { "215903", "zlmdlbdp" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "msczpj" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "smhsm" }, { "dir", "zhq" }, { "€", "clvljpb" }, { "$", "ls" }, { "148686", "fmd" }, { "244875", "mhnlcz" }, { "271194", "qchfgv" }, { "€", ".." }, { "€", "smhsm" }, { "$", "ls" }, { "219572", "ptzhr" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "46118", "qzmbgv.npf" }, { "€", ".." }, { "€", ".." }, { "€", "mvbhn" }, { "$", "ls" }, { "dir", "dnbmm" }, { "17522", "dnbmm.hqp" }, { "dir", "hws" }, { "dir", "hwtsjfbb" }, { "dir", "hzqlb" }, { "dir", "mghrhcsj" }, { "dir", "mprvjd" }, { "180207", "qchfgv" }, { "dir", "qzrshw" }, { "130436", "rdgndm.clf" }, { "128601", "tbdz.bgs" }, { "dir", "vpp" }, { "€", "dnbmm" }, { "$", "ls" }, { "dir", "jqv" }, { "dir", "lcclc" }, { "25762", "rfwdnjzz.stw" }, { "172833", "rpf.vqn" }, { "18217", "zgwwvb.pcs" }, { "€", "jqv" }, { "$", "ls" }, { "dir", "cpbr" }, { "€", "cpbr" }, { "$", "ls" }, { "59543", "mclpq.bpr" }, { "€", ".." }, { "€", ".." }, { "€", "lcclc" }, { "$", "ls" }, { "139444", "jpwdgvb.wgz" }, { "€", ".." }, { "€", ".." }, { "€", "hws" }, { "$", "ls" }, { "42332", "clvljpb" }, { "240502", "clvljpb.bbn" }, { "dir", "jdz" }, { "37624", "pcg.wnr" }, { "dir", "pjd" }, { "169282", "plw.frm" }, { "100105", "tmpll.gwm" }, { "€", "jdz" }, { "$", "ls" }, { "dir", "dnbmm" }, { "€", "dnbmm" }, { "$", "ls" }, { "191941", "cvhvq.rzr" }, { "€", ".." }, { "€", ".." }, { "€", "pjd" }, { "$", "ls" }, { "dir", "bnwjc" }, { "dir", "pgvzhl" }, { "33261", "rvpw.jlj" }, { "dir", "zhq" }, { "€", "bnwjc" }, { "$", "ls" }, { "159772", "lqcbv.mvh" }, { "€", ".." }, { "€", "pgvzhl" }, { "$", "ls" }, { "159506", "nfngbl.mcn" }, { "114670", "qchfgv" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "162563", "mtcd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hwtsjfbb" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "fqclffr" }, { "dir", "hzqlb" }, { "243079", "rqbh.ltt" }, { "dir", "wtz" }, { "€", "clvljpb" }, { "$", "ls" }, { "42146", "bbb" }, { "€", ".." }, { "€", "fqclffr" }, { "$", "ls" }, { "160031", "zgwwvb.pcs" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "70936", "pcg.wnr" }, { "230600", "pfnfjqc.bsp" }, { "154358", "plw.frm" }, { "106007", "qtztf" }, { "€", ".." }, { "€", "wtz" }, { "$", "ls" }, { "265666", "nfngbl.mcn" }, { "dir", "wjsrb" }, { "dir", "zhh" }, { "€", "wjsrb" }, { "$", "ls" }, { "76239", "wqzg" }, { "€", ".." }, { "€", "zhh" }, { "$", "ls" }, { "11571", "wptzslq.gwr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "199430", "gwgrtw.dzv" }, { "€", ".." }, { "€", "mghrhcsj" }, { "$", "ls" }, { "49307", "bvtmfj.dbh" }, { "€", ".." }, { "€", "mprvjd" }, { "$", "ls" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "225705", "nfngbl.mcn" }, { "204180", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", "qzrshw" }, { "$", "ls" }, { "dir", "ddgs" }, { "dir", "hzqlb" }, { "dir", "lmtfhtd" }, { "157122", "qchfgv" }, { "dir", "sjq" }, { "dir", "tdjh" }, { "€", "ddgs" }, { "$", "ls" }, { "174192", "dvb" }, { "100076", "rgdbsfbm.wrd" }, { "18400", "zgwwvb.pcs" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "165950", "plw.frm" }, { "€", ".." }, { "€", "lmtfhtd" }, { "$", "ls" }, { "dir", "clvljpb" }, { "137957", "dnbmm.vjs" }, { "159982", "lgll.lnp" }, { "25796", "plw.frm" }, { "201565", "znj.ljv" }, { "€", "clvljpb" }, { "$", "ls" }, { "248187", "fdvbtnvh.gsc" }, { "€", ".." }, { "€", ".." }, { "€", "sjq" }, { "$", "ls" }, { "dir", "dnbmm" }, { "167394", "dzmj" }, { "143508", "plw.frm" }, { "dir", "sllcrmp" }, { "dir", "ttltfz" }, { "140530", "vdsvw.jhv" }, { "€", "dnbmm" }, { "$", "ls" }, { "224433", "qchfgv" }, { "€", ".." }, { "€", "sllcrmp" }, { "$", "ls" }, { "47580", "hfvh.ncs" }, { "dir", "hgtm" }, { "237683", "nzjzd.zcw" }, { "€", "hgtm" }, { "$", "ls" }, { "194211", "nsddmsvq" }, { "8615", "zgwwvb.pcs" }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "249866", "gbqptvn.pvm" }, { "205314", "jjb.qbl" }, { "€", ".." }, { "€", ".." }, { "€", "tdjh" }, { "$", "ls" }, { "266400", "clvljpb.tmv" }, { "130599", "qdnmmh.trp" }, { "€", ".." }, { "€", ".." }, { "€", "vpp" }, { "$", "ls" }, { "214035", "nfngbl.mcn" }, { "€", ".." }, { "€", ".." }, { "€", "ttjbnj" }, { "$", "ls" }, { "dir", "crlhpd" }, { "47864", "dnbmm" }, { "dir", "ttltfz" }, { "€", "crlhpd" }, { "$", "ls" }, { "dir", "vmgdpf" }, { "€", "vmgdpf" }, { "$", "ls" }, { "169762", "plw.frm" }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "gdf" }, { "dir", "hdh" }, { "dir", "jbfwr" }, { "€", "gdf" }, { "$", "ls" }, { "68861", "plw.frm" }, { "€", ".." }, { "€", "hdh" }, { "$", "ls" }, { "166403", "dnbmm" }, { "€", ".." }, { "€", "jbfwr" }, { "$", "ls" }, { "100770", "pcg.wnr" }, { "178623", "wnswp" }, { "41069", "zmrrmdv.bzr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "234321", "dnbmm" }, { "131214", "dtpprnwf.hfr" }, { "€", ".." }, { "€", "vjj" }, { "$", "ls" }, { "112879", "pgzrb" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "147979", "clvljpb" }, { "dir", "dvm" }, { "136916", "pcg.wnr" }, { "205323", "rwnrfrph" }, { "€", "dvm" }, { "$", "ls" }, { "dir", "cpsqlvbl" }, { "dir", "ffw" }, { "dir", "hzqlb" }, { "95516", "pcg.wnr" }, { "60101", "tcswqq.zjf" }, { "€", "cpsqlvbl" }, { "$", "ls" }, { "dir", "hzqlb" }, { "€", "hzqlb" }, { "$", "ls" }, { "169253", "nscj" }, { "€", ".." }, { "€", ".." }, { "€", "ffw" }, { "$", "ls" }, { "161525", "bpg.rsw" }, { "50629", "dnbmm.qff" }, { "126458", "pcg.wnr" }, { "18268", "trvcmp" }, { "dir", "vwnlb" }, { "171750", "zgwwvb.pcs" }, { "dir", "zhq" }, { "€", "vwnlb" }, { "$", "ls" }, { "218994", "ccjz.qrm" }, { "268399", "srwv" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "150894", "ztcw.dlc" }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "45224", "fnb.vgg" }, { "53728", "nfngbl.mcn" }, { "230460", "zhq.bsw" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zqgcbnrt" }, { "$", "ls" }, { "91447", "bdjbn" }, { "€", ".." }, { "€", ".." }, { "€", "wbvcf" }, { "$", "ls" }, { "dir", "dzh" }, { "€", "dzh" }, { "$", "ls" }, { "250311", "qrvn.bft" }, { "€", ".." }, { "€", ".." }, { "€", "wsqvpp" }, { "$", "ls" }, { "96530", "jwhtlzcm.gmq" }, { "€", ".." }, { "€", ".." }, { "€", "zcvfqn" }, { "$", "ls" }, { "264037", "hzqlb.jfp" }, { "dir", "nlnl" }, { "96691", "qchfgv" }, { "126674", "zhq.ndc" }, { "€", "nlnl" }, { "$", "ls" }, { "248407", "nfngbl.mcn" }, { "188078", "pzwmrfht.dfs" }, { "268160", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "91941", "bgc.grv" }, { "€", ".." }, { "€", "zpb" }, { "$", "ls" }, { "dir", "dnbmm" }, { "dir", "fsw" }, { "€", "dnbmm" }, { "$", "ls" }, { "260358", "lcpg" }, { "dir", "lfm" }, { "€", "lfm" }, { "$", "ls" }, { "227028", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "fsw" }, { "$", "ls" }, { "dir", "fffpsrvp" }, { "153630", "pcg.wnr" }, { "dir", "qtwvgmtl" }, { "2971", "qzl.pcn" }, { "17259", "zrpl.hcc" }, { "€", "fffpsrvp" }, { "$", "ls" }, { "dir", "gflwnfc" }, { "176446", "lwz.pgq" }, { "€", "gflwnfc" }, { "$", "ls" }, { "132820", "cjznqwf.hhq" }, { "224464", "nfngbl.mcn" }, { "104803", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "qtwvgmtl" }, { "$", "ls" }, { "dir", "rcssfd" }, { "€", "rcssfd" }, { "$", "ls" }, { "56266", "htr.chf" }, { "128262", "qcfsth.mlt" }, { "120527", "sqrb" } };
            List<string> directoryList = new List<string>();

            List<List<double>> fileSizesList = new List<List<double>>();

            string currentDirectory = "";
            bool isList = false;
            double total = 0;
            double directoryTotal;

            //sort data
            for (int i = 0; i < dataSet.GetLength(0); i++)
            {
                if (dataSet[i, 0] == "€")
                {
                    currentDirectory = dataSet[i, 1];
                    if (directoryList.IndexOf(currentDirectory) == -1)
                    {
                        directoryList.Add(currentDirectory);
                    }
                    isList = false;
                }
                else if (dataSet[i, 0] == "$")
                {
                    isList = true;
                }
                else if (isList)
                {
                    int currentRowOfFiles = directoryList.IndexOf(currentDirectory);

                    if (dataSet[i, 0] == "dir")
                    {
                        if (directoryList.IndexOf(dataSet[i, 1]) == -1)
                        {
                            directoryList.Add(dataSet[i, 1]);
                        }

                        double dirIndex = directoryList.IndexOf(dataSet[i, 1]);
                        double addRfrns = dirIndex + 0.11;

                        fileSizesList[currentRowOfFiles].Add(addRfrns);

                    }
                    else
                    {
                        fileSizesList[currentRowOfFiles].Add(Convert.ToInt32(directoryList.IndexOf(dataSet[i, 0])));
                        //fileSizesList[currentRowOfFiles].Add(Convert.ToInt32(directoryList[i][0]));
                    }
                }
            }

            //count directory sizes
            for (int i = 0; i < directoryList.Count; i++) //every directory
            {
                bool countUnder100K = true;
                directoryTotal = 0;

                int j = 0;
                while (countUnder100K && j < fileSizesList[i].Count) // while they are not bigger than 100.000
                {
                    if (fileSizesList[i][j] % 1 == 0)
                    {
                        directoryTotal += fileSizesList[i][j];
                    }
                    else
                    {
                        int containdCirectoryListIndex = Convert.ToInt32(fileSizesList[i][j] - 0.11);
                        foreach (double filesize in fileSizesList[containdCirectoryListIndex])
                        {
                            fileSizesList[i].Add(filesize);
                        }
                    }
                    if (directoryTotal > 100000)
                    {
                        countUnder100K = false;
                    }
                    j++;
                }
                if (countUnder100K)
                {
                    total += directoryTotal;
                }

            }

        }
        public static void Part1()
        {
            string[,] dataSet = { { "€", " / " }, { "$", "ls" }, { "dir", "dcvzbqf" }, { "23804", "gsdpmrq.bsz" }, { "24936", "nfngbl.mcn" }, { "178747", "plw.frm" }, { "dir", "qdtw" }, { "dir", "qmfvph" }, { "€", "dcvzbqf" }, { "$", "ls" }, { "dir", "gfvl" }, { "€", "gfvl" }, { "$", "ls" }, { "104564", "dnbmm.bgc" }, { "€", ".." }, { "€", ".." }, { "€", "qdtw" }, { "$", "ls" }, { "dir", "fsj" }, { "dir", "jwfbvmds" }, { "216592", "pcg.wnr" }, { "dir", "pwnhpm" }, { "dir", "qbrpq" }, { "dir", "wdc" }, { "dir", "wpw" }, { "dir", "zbfgmw" }, { "€", "fsj" }, { "$", "ls" }, { "118575", "ltbr.mdf" }, { "€", ".." }, { "€", "jwfbvmds" }, { "$", "ls" }, { "dir", "bbvg" }, { "dir", "bds" }, { "dir", "clvljpb" }, { "44460", "gwbbbgj.hbs" }, { "dir", "hzqlb" }, { "dir", "jpvnzhf" }, { "61025", "trdm.qps" }, { "€", "bbvg" }, { "$", "ls" }, { "219031", "zbzgvsb" }, { "94339", "zhfmsb.lvv" }, { "€", ".." }, { "€", "bds" }, { "$", "ls" }, { "133483", "hzqlb" }, { "€", ".." }, { "€", "clvljpb" }, { "$", "ls" }, { "103511", "bmm.dwc" }, { "121211", "clvljpb.fzn" }, { "158145", "dnbmm.fmm" }, { "74998", "pcg.wnr" }, { "dir", "psvtz" }, { "€", "psvtz" }, { "$", "ls" }, { "dir", "gdj" }, { "167697", "pcgjgc.wgl" }, { "2613", "qchfgv" }, { "91712", "qsdzj.jng" }, { "€", "gdj" }, { "$", "ls" }, { "133897", "qchfgv" }, { "dir", "vmcshh" }, { "93805", "zgmvb.jfg" }, { "€", "vmcshh" }, { "$", "ls" }, { "200517", "zgwwvb.pcs" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "dnbmm" }, { "€", "dnbmm" }, { "$", "ls" }, { "223576", "msrbz.wjs" }, { "€", ".." }, { "€", ".." }, { "€", "jpvnzhf" }, { "$", "ls" }, { "20581", "nfngbl.mcn" }, { "€", ".." }, { "€", ".." }, { "€", "pwnhpm" }, { "$", "ls" }, { "dir", "clvljpb" }, { "33727", "hzqlb.zpp" }, { "39037", "lfjjf.pjt" }, { "163662", "mbwfhq.cjj" }, { "236292", "nfngbl.mcn" }, { "189576", "zvbgnbvf" }, { "€", "clvljpb" }, { "$", "ls" }, { "dir", "clvljpb" }, { "212906", "clvljpb.pls" }, { "214564", "dnm" }, { "dir", "fvgbsft" }, { "230034", "hzqlb.jvz" }, { "48101", "plw.frm" }, { "237902", "qchfgv" }, { "€", "clvljpb" }, { "$", "ls" }, { "dir", "hzqlb" }, { "dir", "zhq" }, { "€", "hzqlb" }, { "$", "ls" }, { "189238", "cvgp" }, { "dir", "gjg" }, { "€", "gjg" }, { "$", "ls" }, { "167082", "ttltfz.bvz" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "203202", "nfngbl.mcn" }, { "212148", "qhnnr.dhs" }, { "€", ".." }, { "€", ".." }, { "€", "fvgbsft" }, { "$", "ls" }, { "dir", "fzhwsjf" }, { "18477", "nps" }, { "dir", "vlplrn" }, { "dir", "vnbg" }, { "dir", "vpc" }, { "€", "fzhwsjf" }, { "$", "ls" }, { "91220", "clvljpb.png" }, { "235721", "pcg.wnr" }, { "61559", "qchfgv" }, { "70762", "vpr.nlc" }, { "€", ".." }, { "€", "vlplrn" }, { "$", "ls" }, { "260247", "qrtnfmln.tpv" }, { "€", ".." }, { "€", "vnbg" }, { "$", "ls" }, { "43069", "ttltfz.mzr" }, { "dir", "wfb" }, { "58219", "zgwwvb.pcs" }, { "272132", "zhq.mrw" }, { "€", "wfb" }, { "$", "ls" }, { "107068", "clvljpb.mtp" }, { "€", ".." }, { "€", ".." }, { "€", "vpc" }, { "$", "ls" }, { "185602", "dnbmm.hfm" }, { "100399", "hzqlb.vtn" }, { "259486", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "qbrpq" }, { "$", "ls" }, { "138169", "cntvzqfm.hgp" }, { "216598", "dnbmm.lhs" }, { "116696", "nfngbl.mcn" }, { "35315", "phf.rvn" }, { "€", ".." }, { "€", "wdc" }, { "$", "ls" }, { "270492", "ghdzdq.ghg" }, { "137119", "lnt.nsd" }, { "€", ".." }, { "€", "wpw" }, { "$", "ls" }, { "dir", "dnbmm" }, { "156266", "jgfv.cpp" }, { "156947", "lvlqcrrs.djl" }, { "dir", "lvznwbpg" }, { "12199", "nfngbl.mcn" }, { "54105", "nlsp" }, { "86737", "zhq.wmz" }, { "€", "dnbmm" }, { "$", "ls" }, { "138125", "lth.hcq" }, { "80844", "nhh.gzc" }, { "149596", "ttltfz.ntn" }, { "€", ".." }, { "€", "lvznwbpg" }, { "$", "ls" }, { "99156", "ldtst.dcr" }, { "217350", "pcg.wnr" }, { "247238", "plw.frm" }, { "dir", "qbqpsccr" }, { "dir", "wnms" }, { "dir", "zhq" }, { "165426", "zmhnzdmb.jnc" }, { "€", "qbqpsccr" }, { "$", "ls" }, { "272199", "pcg.wnr" }, { "219600", "wpjqjm.qwr" }, { "257473", "zhq.zmq" }, { "€", ".." }, { "€", "wnms" }, { "$", "ls" }, { "dir", "ttltfz" }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "btm" }, { "€", "btm" }, { "$", "ls" }, { "dir", "hzqlb" }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "ttltfz" }, { "€", "ttltfz" }, { "$", "ls" }, { "204980", "hzqlb.hhm" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "154868", "srdfz" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zbfgmw" }, { "$", "ls" }, { "dir", "fcjwpgz" }, { "dir", "ttltfz" }, { "dir", "zhq" }, { "€", "fcjwpgz" }, { "$", "ls" }, { "dir", "jltvg" }, { "9958", "qchfgv" }, { "dir", "wwqrb" }, { "€", "jltvg" }, { "$", "ls" }, { "6370", "bssvrjdq.mnr" }, { "€", ".." }, { "€", "wwqrb" }, { "$", "ls" }, { "157805", "npdl" }, { "237057", "qchfgv" }, { "dir", "twrp" }, { "259572", "vptsgw" }, { "176388", "zgwwvb.pcs" }, { "91956", "zhq" }, { "€", "twrp" }, { "$", "ls" }, { "dir", "sfvntjwf" }, { "€", "sfvntjwf" }, { "$", "ls" }, { "68331", "hdwfg.jrl" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "41183", "plw.frm" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "32950", "dmzbmrdr.gtq" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "195502", "dmgmwbf" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "qmfvph" }, { "$", "ls" }, { "dir", "cwfh" }, { "dir", "dnbmm" }, { "dir", "mmmdpth" }, { "4841", "pcg.wnr" }, { "dir", "prnpbn" }, { "111478", "sgmg.hbs" }, { "dir", "ttltfz" }, { "178296", "ttltfz.mjc" }, { "dir", "zcvfqn" }, { "dir", "zhq" }, { "32446", "zhq.pjm" }, { "dir", "zpb" }, { "€", "cwfh" }, { "$", "ls" }, { "dir", "dswtm" }, { "dir", "mwzjf" }, { "€", "dswtm" }, { "$", "ls" }, { "70390", "fmq.mrp" }, { "108185", "qjlfnlp" }, { "189923", "zhq.njc" }, { "€", ".." }, { "€", "mwzjf" }, { "$", "ls" }, { "122536", "glmpd.mdl" }, { "108226", "nfngbl.mcn" }, { "dir", "qbvffr" }, { "33192", "ttltfz" }, { "195824", "zgwwvb.pcs" }, { "€", "qbvffr" }, { "$", "ls" }, { "147595", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "dnbmm" }, { "$", "ls" }, { "dir", "cbdl" }, { "dir", "fhqjzf" }, { "56752", "gsgrnf.mlt" }, { "dir", "ndp" }, { "67967", "nfngbl.mcn" }, { "dir", "swgwdv" }, { "€", "cbdl" }, { "$", "ls" }, { "263964", "dnrbtr.lbh" }, { "66120", "qchfgv" }, { "dir", "qwvd" }, { "€", "qwvd" }, { "$", "ls" }, { "dir", "dnbmm" }, { "143315", "mhlswpcd.lpt" }, { "199969", "ncdrrp.ljf" }, { "€", "dnbmm" }, { "$", "ls" }, { "122474", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "fhqjzf" }, { "$", "ls" }, { "dir", "fnnbrlc" }, { "dir", "hzqlb" }, { "254128", "pcg.wnr" }, { "168008", "plw.frm" }, { "dir", "vwgvd" }, { "dir", "zhq" }, { "€", "fnnbrlc" }, { "$", "ls" }, { "156413", "dnbmm.ngb" }, { "30790", "zbfnjnnz.csg" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "267451", "cgzrdpr" }, { "77460", "nfngbl.mcn" }, { "205978", "plw.frm" }, { "66224", "sjw.ctb" }, { "212873", "zgwwvb.pcs" }, { "€", ".." }, { "€", "vwgvd" }, { "$", "ls" }, { "161177", "phdbz.tmc" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "dir", "hchlgv" }, { "218946", "rfngrlz.zzr" }, { "dir", "zhq" }, { "€", "hchlgv" }, { "$", "ls" }, { "dir", "dnbmm" }, { "270943", "hcpnwbd" }, { "dir", "hzqlb" }, { "13433", "wdljw.cgn" }, { "€", "dnbmm" }, { "$", "ls" }, { "150415", "pcg.wnr" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "44475", "qcvwtfg.wrl" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "155076", "ggndpjzp.rpz" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ndp" }, { "$", "ls" }, { "112146", "nfw.htp" }, { "207815", "vqwtw.qff" }, { "€", ".." }, { "€", "swgwdv" }, { "$", "ls" }, { "dir", "dmqn" }, { "dir", "fzgdjp" }, { "205897", "hzqlb.vtm" }, { "226944", "nfngbl.mcn" }, { "259443", "nrfpz.vmn" }, { "136591", "zgwwvb.pcs" }, { "€", "dmqn" }, { "$", "ls" }, { "258693", "gdplrzt.wzf" }, { "141489", "hzqlb" }, { "225488", "pghz.brw" }, { "€", ".." }, { "€", "fzgdjp" }, { "$", "ls" }, { "206026", "msthjppp" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "mmmdpth" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "hzqlb" }, { "263747", "pcg.wnr" }, { "€", "clvljpb" }, { "$", "ls" }, { "168342", "qhgndmj" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "lqvgqhw" }, { "€", "lqvgqhw" }, { "$", "ls" }, { "218324", "swnjhbj.cqt" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "prnpbn" }, { "$", "ls" }, { "dir", "dndnhn" }, { "176959", "gzhtvt" }, { "85765", "hzqlb.clg" }, { "120691", "nfngbl.mcn" }, { "245942", "qchfgv" }, { "43951", "zgwwvb.pcs" }, { "€", "dndnhn" }, { "$", "ls" }, { "235760", "dhvvnqpt" }, { "dir", "hvg" }, { "dir", "jqvmzg" }, { "dir", "mhz" }, { "€", "hvg" }, { "$", "ls" }, { "167698", "zqbj" }, { "€", ".." }, { "€", "jqvmzg" }, { "$", "ls" }, { "218904", "wppv.mqz" }, { "dir", "zlp" }, { "€", "zlp" }, { "$", "ls" }, { "8030", "wvj.gld" }, { "€", ".." }, { "€", ".." }, { "€", "mhz" }, { "$", "ls" }, { "37541", "tdfvwqlj" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "dnbmm" }, { "dir", "ttltfz" }, { "dir", "wbvcf" }, { "dir", "wsqvpp" }, { "148645", "zgwwvb.pcs" }, { "€", "dnbmm" }, { "$", "ls" }, { "116852", "mjzgll.bcp" }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "hzqlb" }, { "dir", "msczpj" }, { "dir", "mvbhn" }, { "38087", "nfngbl.mcn" }, { "dir", "ttjbnj" }, { "dir", "ttltfz" }, { "dir", "vjj" }, { "dir", "zhq" }, { "dir", "zqgcbnrt" }, { "€", "hzqlb" }, { "$", "ls" }, { "dir", "jshj" }, { "dir", "jtjv" }, { "dir", "mgfwthq" }, { "dir", "zhq" }, { "€", "jshj" }, { "$", "ls" }, { "235605", "cldpdjp.cbc" }, { "dir", "clvljpb" }, { "dir", "dzcnm" }, { "dir", "hmvw" }, { "dir", "hzqlb" }, { "dir", "ltpqhg" }, { "12951", "qchfgv" }, { "dir", "wzvjft" }, { "€", "clvljpb" }, { "$", "ls" }, { "65802", "lnpjlj" }, { "25402", "qrtrvmwl.fms" }, { "€", ".." }, { "€", "dzcnm" }, { "$", "ls" }, { "dir", "cpnwcv" }, { "dir", "hzqlb" }, { "dir", "mjclcntf" }, { "dir", "qnljb" }, { "237105", "rlpvq.fbf" }, { "dir", "zhq" }, { "€", "cpnwcv" }, { "$", "ls" }, { "27600", "qbgclqc.tdd" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "168016", "zhq" }, { "€", ".." }, { "€", "mjclcntf" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "qpjtr" }, { "43145", "zgwwvb.pcs" }, { "€", "clvljpb" }, { "$", "ls" }, { "15025", "plw.frm" }, { "€", ".." }, { "€", "qpjtr" }, { "$", "ls" }, { "54909", "zhq" }, { "€", ".." }, { "€", ".." }, { "€", "qnljb" }, { "$", "ls" }, { "49366", "clvljpb.vtg" }, { "52193", "fnd.tfr" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "105765", "dfnqhggg.cfj" }, { "dir", "hfzgs" }, { "135556", "spff" }, { "129957", "vzgjrc.cbs" }, { "€", "hfzgs" }, { "$", "ls" }, { "52456", "ttltfz.fdq" }, { "31345", "wcmf.hsd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hmvw" }, { "$", "ls" }, { "77175", "flhlwq.rqc" }, { "dir", "gmvqz" }, { "252279", "gnmvm" }, { "dir", "lmbqfhb" }, { "€", "gmvqz" }, { "$", "ls" }, { "129431", "dnbmm.lwl" }, { "€", ".." }, { "€", "lmbqfhb" }, { "$", "ls" }, { "dir", "wjql" }, { "€", "wjql" }, { "$", "ls" }, { "48687", "cgtbqqq.zzs" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "105333", "mqsgqph" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "116802", "hbtlhjn.dvs" }, { "8842", "pcg.wnr" }, { "211096", "plw.frm" }, { "€", ".." }, { "€", ".." }, { "€", "ltpqhg" }, { "$", "ls" }, { "245821", "hchndjgj.vht" }, { "229181", "rcfmhrqm.ftc" }, { "214977", "vgdsjg.jpd" }, { "124547", "zgwwvb.pcs" }, { "€", ".." }, { "€", "wzvjft" }, { "$", "ls" }, { "dir", "fdntdf" }, { "174465", "pcg.wnr" }, { "80888", "qchfgv" }, { "82987", "rqbzbrlv" }, { "€", "fdntdf" }, { "$", "ls" }, { "79808", "cmlt.cvd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "jtjv" }, { "$", "ls" }, { "262350", "zww.fbl" }, { "€", ".." }, { "€", "mgfwthq" }, { "$", "ls" }, { "32365", "gjq.rpz" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "dfdbzzz" }, { "dir", "lqhfbp" }, { "152633", "nfngbl.mcn" }, { "€", "clvljpb" }, { "$", "ls" }, { "72966", "scs" }, { "€", ".." }, { "€", "dfdbzzz" }, { "$", "ls" }, { "206453", "cgrdn.dcw" }, { "€", ".." }, { "€", "lqhfbp" }, { "$", "ls" }, { "141515", "nlvswpcm.fvm" }, { "68018", "zgwwvb.pcs" }, { "215903", "zlmdlbdp" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "msczpj" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "smhsm" }, { "dir", "zhq" }, { "€", "clvljpb" }, { "$", "ls" }, { "148686", "fmd" }, { "244875", "mhnlcz" }, { "271194", "qchfgv" }, { "€", ".." }, { "€", "smhsm" }, { "$", "ls" }, { "219572", "ptzhr" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "46118", "qzmbgv.npf" }, { "€", ".." }, { "€", ".." }, { "€", "mvbhn" }, { "$", "ls" }, { "dir", "dnbmm" }, { "17522", "dnbmm.hqp" }, { "dir", "hws" }, { "dir", "hwtsjfbb" }, { "dir", "hzqlb" }, { "dir", "mghrhcsj" }, { "dir", "mprvjd" }, { "180207", "qchfgv" }, { "dir", "qzrshw" }, { "130436", "rdgndm.clf" }, { "128601", "tbdz.bgs" }, { "dir", "vpp" }, { "€", "dnbmm" }, { "$", "ls" }, { "dir", "jqv" }, { "dir", "lcclc" }, { "25762", "rfwdnjzz.stw" }, { "172833", "rpf.vqn" }, { "18217", "zgwwvb.pcs" }, { "€", "jqv" }, { "$", "ls" }, { "dir", "cpbr" }, { "€", "cpbr" }, { "$", "ls" }, { "59543", "mclpq.bpr" }, { "€", ".." }, { "€", ".." }, { "€", "lcclc" }, { "$", "ls" }, { "139444", "jpwdgvb.wgz" }, { "€", ".." }, { "€", ".." }, { "€", "hws" }, { "$", "ls" }, { "42332", "clvljpb" }, { "240502", "clvljpb.bbn" }, { "dir", "jdz" }, { "37624", "pcg.wnr" }, { "dir", "pjd" }, { "169282", "plw.frm" }, { "100105", "tmpll.gwm" }, { "€", "jdz" }, { "$", "ls" }, { "dir", "dnbmm" }, { "€", "dnbmm" }, { "$", "ls" }, { "191941", "cvhvq.rzr" }, { "€", ".." }, { "€", ".." }, { "€", "pjd" }, { "$", "ls" }, { "dir", "bnwjc" }, { "dir", "pgvzhl" }, { "33261", "rvpw.jlj" }, { "dir", "zhq" }, { "€", "bnwjc" }, { "$", "ls" }, { "159772", "lqcbv.mvh" }, { "€", ".." }, { "€", "pgvzhl" }, { "$", "ls" }, { "159506", "nfngbl.mcn" }, { "114670", "qchfgv" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "162563", "mtcd" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hwtsjfbb" }, { "$", "ls" }, { "dir", "clvljpb" }, { "dir", "fqclffr" }, { "dir", "hzqlb" }, { "243079", "rqbh.ltt" }, { "dir", "wtz" }, { "€", "clvljpb" }, { "$", "ls" }, { "42146", "bbb" }, { "€", ".." }, { "€", "fqclffr" }, { "$", "ls" }, { "160031", "zgwwvb.pcs" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "70936", "pcg.wnr" }, { "230600", "pfnfjqc.bsp" }, { "154358", "plw.frm" }, { "106007", "qtztf" }, { "€", ".." }, { "€", "wtz" }, { "$", "ls" }, { "265666", "nfngbl.mcn" }, { "dir", "wjsrb" }, { "dir", "zhh" }, { "€", "wjsrb" }, { "$", "ls" }, { "76239", "wqzg" }, { "€", ".." }, { "€", "zhh" }, { "$", "ls" }, { "11571", "wptzslq.gwr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "199430", "gwgrtw.dzv" }, { "€", ".." }, { "€", "mghrhcsj" }, { "$", "ls" }, { "49307", "bvtmfj.dbh" }, { "€", ".." }, { "€", "mprvjd" }, { "$", "ls" }, { "dir", "zhq" }, { "€", "zhq" }, { "$", "ls" }, { "225705", "nfngbl.mcn" }, { "204180", "pcg.wnr" }, { "€", ".." }, { "€", ".." }, { "€", "qzrshw" }, { "$", "ls" }, { "dir", "ddgs" }, { "dir", "hzqlb" }, { "dir", "lmtfhtd" }, { "157122", "qchfgv" }, { "dir", "sjq" }, { "dir", "tdjh" }, { "€", "ddgs" }, { "$", "ls" }, { "174192", "dvb" }, { "100076", "rgdbsfbm.wrd" }, { "18400", "zgwwvb.pcs" }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "165950", "plw.frm" }, { "€", ".." }, { "€", "lmtfhtd" }, { "$", "ls" }, { "dir", "clvljpb" }, { "137957", "dnbmm.vjs" }, { "159982", "lgll.lnp" }, { "25796", "plw.frm" }, { "201565", "znj.ljv" }, { "€", "clvljpb" }, { "$", "ls" }, { "248187", "fdvbtnvh.gsc" }, { "€", ".." }, { "€", ".." }, { "€", "sjq" }, { "$", "ls" }, { "dir", "dnbmm" }, { "167394", "dzmj" }, { "143508", "plw.frm" }, { "dir", "sllcrmp" }, { "dir", "ttltfz" }, { "140530", "vdsvw.jhv" }, { "€", "dnbmm" }, { "$", "ls" }, { "224433", "qchfgv" }, { "€", ".." }, { "€", "sllcrmp" }, { "$", "ls" }, { "47580", "hfvh.ncs" }, { "dir", "hgtm" }, { "237683", "nzjzd.zcw" }, { "€", "hgtm" }, { "$", "ls" }, { "194211", "nsddmsvq" }, { "8615", "zgwwvb.pcs" }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "249866", "gbqptvn.pvm" }, { "205314", "jjb.qbl" }, { "€", ".." }, { "€", ".." }, { "€", "tdjh" }, { "$", "ls" }, { "266400", "clvljpb.tmv" }, { "130599", "qdnmmh.trp" }, { "€", ".." }, { "€", ".." }, { "€", "vpp" }, { "$", "ls" }, { "214035", "nfngbl.mcn" }, { "€", ".." }, { "€", ".." }, { "€", "ttjbnj" }, { "$", "ls" }, { "dir", "crlhpd" }, { "47864", "dnbmm" }, { "dir", "ttltfz" }, { "€", "crlhpd" }, { "$", "ls" }, { "dir", "vmgdpf" }, { "€", "vmgdpf" }, { "$", "ls" }, { "169762", "plw.frm" }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "dir", "gdf" }, { "dir", "hdh" }, { "dir", "jbfwr" }, { "€", "gdf" }, { "$", "ls" }, { "68861", "plw.frm" }, { "€", ".." }, { "€", "hdh" }, { "$", "ls" }, { "166403", "dnbmm" }, { "€", ".." }, { "€", "jbfwr" }, { "$", "ls" }, { "100770", "pcg.wnr" }, { "178623", "wnswp" }, { "41069", "zmrrmdv.bzr" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "ttltfz" }, { "$", "ls" }, { "234321", "dnbmm" }, { "131214", "dtpprnwf.hfr" }, { "€", ".." }, { "€", "vjj" }, { "$", "ls" }, { "112879", "pgzrb" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "147979", "clvljpb" }, { "dir", "dvm" }, { "136916", "pcg.wnr" }, { "205323", "rwnrfrph" }, { "€", "dvm" }, { "$", "ls" }, { "dir", "cpsqlvbl" }, { "dir", "ffw" }, { "dir", "hzqlb" }, { "95516", "pcg.wnr" }, { "60101", "tcswqq.zjf" }, { "€", "cpsqlvbl" }, { "$", "ls" }, { "dir", "hzqlb" }, { "€", "hzqlb" }, { "$", "ls" }, { "169253", "nscj" }, { "€", ".." }, { "€", ".." }, { "€", "ffw" }, { "$", "ls" }, { "161525", "bpg.rsw" }, { "50629", "dnbmm.qff" }, { "126458", "pcg.wnr" }, { "18268", "trvcmp" }, { "dir", "vwnlb" }, { "171750", "zgwwvb.pcs" }, { "dir", "zhq" }, { "€", "vwnlb" }, { "$", "ls" }, { "218994", "ccjz.qrm" }, { "268399", "srwv" }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "150894", "ztcw.dlc" }, { "€", ".." }, { "€", ".." }, { "€", "hzqlb" }, { "$", "ls" }, { "45224", "fnb.vgg" }, { "53728", "nfngbl.mcn" }, { "230460", "zhq.bsw" }, { "€", ".." }, { "€", ".." }, { "€", ".." }, { "€", "zqgcbnrt" }, { "$", "ls" }, { "91447", "bdjbn" }, { "€", ".." }, { "€", ".." }, { "€", "wbvcf" }, { "$", "ls" }, { "dir", "dzh" }, { "€", "dzh" }, { "$", "ls" }, { "250311", "qrvn.bft" }, { "€", ".." }, { "€", ".." }, { "€", "wsqvpp" }, { "$", "ls" }, { "96530", "jwhtlzcm.gmq" }, { "€", ".." }, { "€", ".." }, { "€", "zcvfqn" }, { "$", "ls" }, { "264037", "hzqlb.jfp" }, { "dir", "nlnl" }, { "96691", "qchfgv" }, { "126674", "zhq.ndc" }, { "€", "nlnl" }, { "$", "ls" }, { "248407", "nfngbl.mcn" }, { "188078", "pzwmrfht.dfs" }, { "268160", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "zhq" }, { "$", "ls" }, { "91941", "bgc.grv" }, { "€", ".." }, { "€", "zpb" }, { "$", "ls" }, { "dir", "dnbmm" }, { "dir", "fsw" }, { "€", "dnbmm" }, { "$", "ls" }, { "260358", "lcpg" }, { "dir", "lfm" }, { "€", "lfm" }, { "$", "ls" }, { "227028", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "fsw" }, { "$", "ls" }, { "dir", "fffpsrvp" }, { "153630", "pcg.wnr" }, { "dir", "qtwvgmtl" }, { "2971", "qzl.pcn" }, { "17259", "zrpl.hcc" }, { "€", "fffpsrvp" }, { "$", "ls" }, { "dir", "gflwnfc" }, { "176446", "lwz.pgq" }, { "€", "gflwnfc" }, { "$", "ls" }, { "132820", "cjznqwf.hhq" }, { "224464", "nfngbl.mcn" }, { "104803", "qchfgv" }, { "€", ".." }, { "€", ".." }, { "€", "qtwvgmtl" }, { "$", "ls" }, { "dir", "rcssfd" }, { "€", "rcssfd" }, { "$", "ls" }, { "56266", "htr.chf" }, { "128262", "qcfsth.mlt" }, { "120527", "sqrb" } };

            List<string> directoryList = new List<string>();

            List<List<double>> fileSizesGrid = new List<List<double>>();

            string currentDirectory = "";
            int currentDirectoryIndex = -1;
            bool isList = false;

            for (int i = 0; i < dataSet.GetLength(0); i++)
            {
                if (dataSet[i, 0] == "€")
                {
                    currentDirectory = dataSet[i, 1];
                    if (directoryList.IndexOf(currentDirectory) < 0)
                    {
                        directoryList.Add(currentDirectory);
                        fileSizesGrid.Add(new List<double>());
                    }
                    isList = false;


                }
                else if (dataSet[i, 0] == "$")
                {
                    isList = true;

                }
                else if (isList)
                {
                    currentDirectoryIndex = directoryList.IndexOf(currentDirectory);

                    if (dataSet[i, 0] == "dir")
                    {
                        if (directoryList.IndexOf(dataSet[i, 1]) < 0)
                        {
                            directoryList.Add(dataSet[i, 1]);
                            fileSizesGrid.Add(new List<double>());
                        }
                        double addRefrence = directoryList.IndexOf(dataSet[i, 1]) + 0.11;


                        fileSizesGrid[currentDirectoryIndex].Add(addRefrence);
                    }
                    else
                    {
                        fileSizesGrid[currentDirectoryIndex].Add(Convert.ToDouble(dataSet[i, 0]));
                    }
                }
            }

            CountFileSizes(directoryList, fileSizesGrid);

            // 1098082 is to low
        }
        public static void CountFileSizes(List<string> directoryList, List<List<double>> fileGrid)
        {

            double total = 0;
            bool under100001;
            double directoryTotal;
            for (int i = 0; i < fileGrid.Count; i++)
            {
                under100001 = true;
                directoryTotal = 0;

                int j = 0;
                while (j < fileGrid[i].Count && under100001)
                {
                    if (fileGrid[i][j] % 1 == 0)
                    {
                        directoryTotal += fileGrid[i][j];
                    }
                    else
                    {
                        int subDirectoryIndex = Convert.ToInt32(fileGrid[i][j] - 0.11);
                        for (int k = 0; k < fileGrid[subDirectoryIndex].Count; k++)
                        {
                            fileGrid[i].Add(fileGrid[subDirectoryIndex][k]);
                        }
                    }

                    if (directoryTotal > 100000)
                    {
                        under100001 = false;
                    }
                    j++;
                }
                if (under100001)
                {
                    total += directoryTotal;
                }
            }


            Console.WriteLine(total);
        }
        internal class Directory
        {
            public static List<Directory> AllDirectories = new List<Directory>();
            private static int maxId = -1;

            public string Name;
            public int Id;
            public int ParentId;

            public Dictionary<int, string> Directories = new Dictionary<int, string>();
            public Dictionary<string, ulong> Files = new Dictionary<string, ulong>();

            

            public ulong TotalSize = 0;

            public Directory(string name)
            {
                this.Id = maxId;
                maxId++;
                this.Name = name;
            }
            public Directory(string name, int PId)
            {
                this.Name = name;
                this.ParentId = PId;
                this.Id = maxId;
                maxId++;
                AllDirectories.Add(this);
            }
            public void AddD(string name)
            {
                Directory newD = new Directory(name, this.Id);
                this.Directories.Add(newD.Id, name);
            }
            public void CalculateFileSize()
            {
                ulong sum = 0;
                foreach(var file in this.Files)
                {
                    sum += file.Value;
                }
                this.TotalSize = sum;
            }
            public static void CalculateFileSizes()
            {
                foreach(var directory in AllDirectories)
                {
                    directory.CalculateFileSize();
                }
            }

            public ulong GetSize()
            {
                ulong sum = this.TotalSize;

                foreach(var d in this.Directories.Keys)
                {
                    Directory dir = AllDirectories[d];

                    sum += dir.GetSize();
                }
                this.TotalSize = sum;
                return sum;
            }





            //public uint GetSize(uint max)
            //{
            //    uint totalSize = 0;


            //    foreach (var file in this.Files)
            //    {
            //        totalSize += file.Value;
            //        if (totalSize > max)
            //        {
            //            BigDirectories.Add(this.Name);
            //            return 100001;
            //        }
            //    }

            //    foreach (var directory in this.Directories)
            //    {
            //        totalSize += Directory.AllDirectories.Find(x => x.Name == directory).GetSize(100000);
            //        if (totalSize > max)
            //        {
            //            BigDirectories.Add(this.Name);
            //            return 100001;
            //        }
            //    }


            //    return totalSize;
            //}

        }
        public static void Part1Try3()
        {
            List<string> data = Input.Day7.Full();
            Directory currentD = new Directory("C:");
            currentD.AddD("/");
            bool listing = true;

            foreach(string line in data)
            {

                string[] dataParts = line.Split(' ');


                if (dataParts[0] == "$")
                {
                    listing = false;

                    if (dataParts[1] == "cd")
                    {
                        string goToName = dataParts[2];
                        if (goToName == "..")
                        {
                            currentD = Directory.AllDirectories[currentD.ParentId];
                        }
                        foreach (var directory in currentD.Directories)
                        {
                            if (directory.Value == goToName)
                            {
                                currentD = Directory.AllDirectories[directory.Key];
                                break;
                            }
                        }
                    }
                    else if(currentD.Directories.Count == 0)
                    {
                        listing = true;
                    }
                }
                else if (listing)
                {
                    if (dataParts[0] == "dir")
                    {
                        currentD.AddD(dataParts[1]);
                    }
                    else
                    {
                        currentD.Files.Add(dataParts[1], Convert.ToUInt32(dataParts[0]));
                    }

                }

            }

            ulong sum = 0;

            //foreach (var directory in Directory.AllDirectories)
            //{
            //    uint thisDSize = directory.GetSize(100000);
            //    if(thisDSize <= 100000)
            //    {
            //        sum += thisDSize;
            //    }
            //}


            //Directory.FindBigD(100000);

            Directory.CalculateFileSizes();
            // now every directory should have the total sum of its own files in the TotalSize attribute.



            //Directory.AllDirectories.Find(x => x.Name == "/").GetSize();

            int runtrues = 0;
            bool looking;
            do
            {
                runtrues++;
                looking = false;
                foreach(var d in Directory.AllDirectories)
                {
                    ulong currentSize = d.TotalSize;
                    if(d.TotalSize < 100001)
                    {
                        d.CalculateFileSize();

                        foreach (var d2 in d.Directories.Keys)
                        {
                            d.TotalSize += Directory.AllDirectories[d2].TotalSize;

                            if (d.TotalSize > 100000)
                            {
                                d.TotalSize = 100001;
                                looking = true;

                            }
                        }
                    }
                    if(currentSize != d.TotalSize)
                    {
                        looking = true;
                    }

                }

            } while (looking);


            Console.WriteLine(runtrues);


            foreach(var d in Directory.AllDirectories)
            {
                if(d.TotalSize <= 100000)
                {
                    sum += d.TotalSize;
                }
            }


            Console.WriteLine(sum);



            // 11898190 is not right
            // 1543140  is the right answer
        }
        public static void Part2()
        {
            List<string> data = Input.Day7.Full();
            Directory currentD = new Directory("C:");
            currentD.AddD("/");
            bool listing = true;

            foreach (string line in data)
            {

                string[] dataParts = line.Split(' ');


                if (dataParts[0] == "$")
                {
                    listing = false;

                    if (dataParts[1] == "cd")
                    {
                        string goToName = dataParts[2];
                        if (goToName == "..")
                        {
                            currentD = Directory.AllDirectories[currentD.ParentId];
                        }
                        foreach (var directory in currentD.Directories)
                        {
                            if (directory.Value == goToName)
                            {
                                currentD = Directory.AllDirectories[directory.Key];
                                break;
                            }
                        }
                    }
                    else if (currentD.Directories.Count == 0)
                    {
                        listing = true;
                    }
                }
                else if (listing)
                {
                    if (dataParts[0] == "dir")
                    {
                        currentD.AddD(dataParts[1]);
                    }
                    else
                    {
                        currentD.Files.Add(dataParts[1], Convert.ToUInt32(dataParts[0]));
                    }

                }

            }

            ulong sum = 0;


            Directory.CalculateFileSizes();
            // now every directory should have the total sum of its own files in the TotalSize attribute.


            int runtrues = 0;
            bool looking;
            do
            {
                runtrues++;
                looking = false;
                foreach (var d in Directory.AllDirectories)
                {
                    ulong currentSize = d.TotalSize;

                    d.CalculateFileSize();

                    foreach (var d2 in d.Directories.Keys)
                    {
                        d.TotalSize += Directory.AllDirectories[d2].TotalSize;

                    }

                    if (currentSize != d.TotalSize)
                    {
                        looking = true;
                    }

                }

            } while (looking);


            Console.WriteLine(runtrues);

            ulong rootSize = Directory.AllDirectories.Find(x => x.Name == "/").TotalSize;

            ulong spaceLeft = 70000000 - rootSize;

            ulong spaceNeeded = 30000000 - spaceLeft;

            ulong deleteSize = 70000000;

            foreach (var d in Directory.AllDirectories)
            {
                if (d.TotalSize >= spaceNeeded /*&& d.TotalSize < deleteSize*/)
                {
                    deleteSize = d.TotalSize;
                }
            }


            Console.WriteLine(deleteSize);


        }
    }
}
