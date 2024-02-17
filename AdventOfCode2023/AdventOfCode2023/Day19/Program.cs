namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // absolute max = 256.000.000.000.000

            // 117750336930676
            // 167409079868000


            string input = "qbl{m<1574:A,R}\r\nspp{a<2917:znm,a>3411:hqz,a<3171:sm,mt}\r\nhr{m>2184:R,R}\r\nts{m<252:R,m<371:R,a>3579:A,fn}\r\njqx{a>2040:csq,nxz}\r\nqft{x>2939:R,R}\r\nnm{a<2683:A,R}\r\nstf{x<3354:R,s<3146:rxb,R}\r\nsz{s>1324:csh,s>1102:qhv,smb}\r\nqm{s<2419:tf,fhq}\r\nln{s<3452:sdc,s>3806:R,a>3329:mn,gtv}\r\nsv{m<2846:A,s>805:R,R}\r\nmrb{s<892:A,A}\r\njtg{m>1009:pkt,a<3010:lzx,sp}\r\njq{x>3362:pk,x<3274:zxr,sjh}\r\nvhl{a<3085:R,A}\r\nlgm{s<1828:R,m<1467:R,s>2175:R,A}\r\npkh{a>2156:R,a>1190:R,R}\r\nmtk{s>339:A,m>545:A,R}\r\nvf{x>3575:gn,bzr}\r\nrlr{s<2506:R,pkh}\r\nzq{a>892:jcv,R}\r\nvp{x<3837:zj,m<702:A,A}\r\nhh{s>3225:thg,sjz}\r\nlfg{m>3773:dbb,s>721:R,ppq}\r\nzcl{a<1277:A,m>1478:R,A}\r\nmxn{m<3702:zss,s>2616:R,s>1078:vhh,R}\r\nng{s>1410:qc,m<3268:fv,m<3580:tn,lfg}\r\ntcq{x>3342:A,a<2914:R,s>3111:R,A}\r\njs{x>2628:smq,x>2608:A,vhl}\r\nqp{s<1594:R,x>1781:R,A}\r\nsxj{s>387:R,m<1853:A,R}\r\nrdk{m<1026:rtm,xq}\r\nzh{a<889:bxn,qpb}\r\nhz{x<2951:A,R}\r\nchm{x<3403:A,x<3456:tmh,R}\r\nrds{a>2494:A,A}\r\nnk{s<1558:R,A}\r\nzv{s>1894:fqt,lrt}\r\nrb{s>1278:zvr,m<1005:lr,s>621:hk,gq}\r\njxq{x<3571:lgq,s<720:R,R}\r\nxf{a<2719:pj,a<2885:hfd,ctj}\r\nklx{x<3699:R,m>3744:A,x>3898:A,A}\r\nfgr{m>3061:A,x<3000:A,A}\r\nbzx{m>3605:gkz,m>3474:A,mpt}\r\nlh{s>2838:R,s>2364:R,a>3340:A,R}\r\ncm{a<2481:jkn,m>2949:szf,a<3313:zkv,zv}\r\nddv{a<2893:R,R}\r\nbn{s<3160:R,x>3364:R,A}\r\nrbq{a>1335:R,s<1190:R,x>2922:R,R}\r\nzht{m>2105:R,s<2964:R,a>2355:A,R}\r\nqpb{a<1387:A,s<2729:A,R}\r\nfvz{x>2841:R,m<1023:R,A}\r\nhzm{m>1472:R,a>832:R,s<1216:A,R}\r\nssz{x>3330:glv,R}\r\nnh{x<2958:lhn,htg}\r\ndvb{a<814:frh,x<3522:chm,gfb}\r\nxjg{a<2980:A,R}\r\ncxt{s<2875:R,x>2821:R,R}\r\nngt{s<1276:hj,s>1582:llm,m<1387:nxp,tnn}\r\nlgr{x>1156:R,a<2652:A,a>2752:R,A}\r\ngls{s<1517:vdr,s>3140:cr,R}\r\ndkt{a<3070:A,R}\r\nsqp{x>3128:A,a>3717:A,A}\r\ntrm{x<3807:A,x>3932:R,s>2867:R,A}\r\nfxv{x<3060:A,m<3872:R,m<3957:R,R}\r\nsc{m>2545:crq,mkl}\r\ntf{m>2267:nhb,s<1269:rdk,a<2660:xmg,hd}\r\nbmk{m<2909:R,R}\r\nff{x<166:R,m>1657:R,x<203:A,A}\r\nddg{s<3171:vkz,m<2032:hnj,sgv}\r\nkvk{a<730:qb,s>2582:A,s<1642:A,R}\r\nvdr{a>732:R,A}\r\nzbc{s>3491:A,s>3354:R,A}\r\nmq{m>879:A,s>3182:kz,R}\r\nkh{x>3303:R,R}\r\nsn{a<3085:R,x<3638:R,a<3223:R,R}\r\nfx{s<3365:A,s<3768:A,x<2290:A,A}\r\nzl{m<1180:A,A}\r\nsrj{s<2766:R,R}\r\nsjz{a>2925:R,x<904:A,s>2888:pcb,bdj}\r\nfq{m>3351:nh,s<964:hjh,s>1387:gtg,hz}\r\ncrb{m<1900:A,s<970:R,a<3511:R,A}\r\nzx{m<1529:cn,mr}\r\nfz{m>853:A,A}\r\ncl{m<3570:nf,s>3104:jn,A}\r\nxsj{a>1327:R,R}\r\ngz{s>2087:xt,a>2786:phh,jxq}\r\nsr{a<686:nsx,s>2475:dv,rc}\r\ngv{m<1324:R,R}\r\nrnf{x<360:R,vg}\r\nljq{a>2095:R,a<1982:A,a>2041:A,A}\r\nsq{a<2885:R,A}\r\nrlp{a>3714:mxn,rq}\r\nhfd{s>3346:nj,R}\r\nnd{a<920:A,A}\r\nhnj{a<2808:A,x>2971:R,s<3552:A,A}\r\njlm{m<3824:A,R}\r\nxck{s>2449:jc,s>1262:jgl,s>736:qbl,znr}\r\njjn{m>2086:lt,krr}\r\njp{a<2407:bkh,gkj}\r\nszf{m<3345:lfj,a>3306:rlp,a>2761:zrq,rfr}\r\nqvt{m>2876:R,x>908:R,x>766:A,R}\r\npfn{s<3150:A,m<268:R,m<465:A,R}\r\nkq{s<3578:A,A}\r\nld{m>632:rb,jq}\r\nfg{a<1947:gd,x<2011:R,A}\r\npcb{s>3005:R,m>2426:R,A}\r\nmqv{s<2651:A,A}\r\nzp{m<3217:R,A}\r\nbpr{a<3504:A,s<2171:A,A}\r\nnks{s<2655:nx,x>2777:sl,jzt}\r\nzxr{x>3230:lvt,A}\r\nlzx{x<2988:R,x<3006:pb,mqv}\r\nhqz{m<910:sqp,a>3760:R,a<3608:R,klp}\r\nzrq{s<1965:xlf,hgj}\r\ngff{a>3296:A,m>3091:A,x>3604:R,lzz}\r\nsp{s<3082:dgp,s>3562:R,R}\r\nvck{a>3564:R,s>1343:A,R}\r\ntc{x<2801:A,R}\r\ncnn{m>836:ggb,a<2366:srz,kxz}\r\nvm{a<3067:ffl,m>1054:R,R}\r\nklp{m<1643:A,s>3100:A,A}\r\nzs{s<2623:prv,R}\r\nxsq{a<3078:A,x>3368:A,A}\r\nggb{x<3799:ndv,a<1843:lcv,a<2735:gv,fth}\r\nsmq{m>1630:A,a>3389:R,m<889:A,A}\r\njlf{s<2601:qq,A}\r\nmkl{s<1824:xcv,a<1755:zx,x>2924:xh,lg}\r\njkn{a>1538:dqd,s<2181:dvb,lq}\r\nfrh{a<451:hv,x<3680:svr,m<2584:zk,R}\r\nlpc{a<2220:nvs,x>2723:qlh,nvq}\r\nxpr{s<2224:A,R}\r\nhbz{s>742:A,m>2908:A,s>407:A,A}\r\nghb{m<735:zf,m>1232:bq,sr}\r\nqr{a<1056:kf,x>2726:R,x>2659:A,xsj}\r\nljg{a>3202:R,R}\r\nlt{a>3783:R,m<2991:R,znx}\r\nlf{x<2866:A,R}\r\nnkc{a<2896:A,A}\r\njjj{a>1170:A,A}\r\nvcp{a<3476:A,x<1527:R,A}\r\ncs{x<2769:A,A}\r\nxk{m<1429:xj,x<3451:dqf,a<864:R,fhd}\r\ncsq{m>133:R,s>3174:R,s<2646:R,A}\r\ncjf{s<2500:A,x>2966:R,s<2537:R,R}\r\npch{a>3402:R,x<3970:R,A}\r\ndzb{m>1629:lch,x>3070:A,a>1344:R,vcg}\r\npkt{m<1118:A,m>1245:kqz,s<2841:A,pcp}\r\nqtr{x>1871:nd,x>1665:A,m<1246:R,A}\r\nnc{m<1646:mrb,s<1348:gr,a>2803:np,tfx}\r\nxcq{m<3438:A,A}\r\nlq{x>3504:pt,zq}\r\nljs{a<2509:R,R}\r\nkxz{a<3295:hcv,m<456:ts,m<593:vck,vp}\r\nccd{a>3532:jvl,m>2141:xdb,csf}\r\nzzk{a>2448:ffg,rnf}\r\nksf{m<252:jqx,a>2045:nks,s>3221:xgp,msk}\r\ntb{a<884:R,s>3121:R,x>868:A,R}\r\nmpt{a<1121:R,x>2693:A,R}\r\nxxp{m<2396:A,m>2746:R,a>3081:A,R}\r\nzf{s<2583:ssz,a>1125:mx,dq}\r\nltt{m<1914:A,A}\r\njk{s>2586:A,R}\r\nvhh{x<3465:A,a>3842:A,A}\r\nzcc{s>3452:R,a>1752:R,A}\r\nmp{a>2083:A,R}\r\nxq{s>435:rr,R}\r\nxh{x>3037:spp,m>1334:ddg,m>463:jtg,ft}\r\njzr{m>2421:xs,ml}\r\ngr{a<2740:qvt,x>1030:R,sx}\r\njzt{a<2287:R,a>2424:R,R}\r\npqv{m<562:R,a>514:R,R}\r\ntk{x<2906:zm,A}\r\ntv{a<2090:hvc,x>660:rbg,bpk}\r\nll{a>2966:R,x<3296:R,x>3419:ddv,tcq}\r\nssd{s>1230:ch,m>3227:vb,a<3339:xr,hbz}\r\nmck{m<997:mtk,ssg}\r\nmbm{s<3035:A,a<2993:R,s>3381:R,A}\r\nknc{a<717:A,A}\r\nnj{s>3662:R,R}\r\nkt{m<1393:R,R}\r\nzm{m>3077:R,s<1102:R,R}\r\nxp{m<555:R,m<686:R,R}\r\nkcz{m<958:A,s>3307:A,R}\r\nlch{a<2420:A,A}\r\nlsg{m>841:A,a>2937:R,A}\r\nlgg{s<3631:R,zkg}\r\ndt{x>2282:R,s>1907:R,R}\r\nnxz{s<2740:R,x<2788:R,s<3169:R,R}\r\nml{x>3641:R,A}\r\nfk{a<3560:R,R}\r\nbkh{m>3566:gks,R}\r\nvd{s<821:R,R}\r\nzkv{m>2074:vf,gz}\r\ntxl{x>2986:R,A}\r\nxj{m>1331:A,a>607:R,A}\r\nkf{a<649:R,R}\r\nzk{s<899:R,m>2066:R,R}\r\nlvs{a<705:R,a<872:A,s>3101:R,A}\r\nbpk{a<2727:zzk,s>1544:vc,a>3548:jjn,zbt}\r\nznm{s<2638:A,m>1174:rs,R}\r\nfb{x>2811:xrx,m<1973:R,R}\r\nxl{a<3521:A,R}\r\nlrt{a<3626:hc,tj}\r\nrfr{a<2578:xc,x>3692:gxf,nm}\r\ncv{a<3435:R,s<2464:A,a>3715:A,R}\r\ndm{m>2201:R,R}\r\nnhb{s<1451:fg,bj}\r\nin{x<2577:xx,x>3180:gj,sc}\r\nrhg{x<1974:R,x>2182:A,m>829:A,A}\r\nlg{a>2525:hb,m>1244:lpc,m<658:ksf,nz}\r\njd{m>2179:zp,m<1381:spr,m>1732:R,R}\r\ntxp{m>1927:cv,kb}\r\njr{a<1781:A,a>1902:R,A}\r\nhd{x>1750:kt,rgg}\r\ngxf{m<3755:nk,a<2695:A,R}\r\nfrz{x>1759:A,s<3233:A,m<654:R,R}\r\ndz{x<1223:A,m<2655:R,a>644:A,A}\r\nhtg{m<3741:A,m<3868:R,x>3045:A,R}\r\ngks{x>3093:A,m<3813:A,s<3256:R,A}\r\nlzz{m<2999:A,a<2878:R,a>3038:A,R}\r\nbpf{s<3163:R,A}\r\nzgd{a<1196:R,a>1317:R,A}\r\nvg{m<2455:A,a>2304:A,x<541:A,R}\r\nbcf{m>348:A,m<191:A,R}\r\npxv{x<3389:A,m>146:A,m>67:R,A}\r\npg{a<2806:R,x<3213:A,s<272:R,R}\r\nsh{m<3146:A,s>2832:R,x>1900:R,R}\r\nnz{x>2724:tjh,s>3242:lgg,jhc}\r\nfqt{a>3693:srj,mnv}\r\nxpf{m<2849:kq,a>1701:R,qtq}\r\nnqx{m>160:xpr,qv}\r\nxc{a<2525:ljs,s>2083:klx,s<1150:A,hqg}\r\nhc{m<2344:crb,A}\r\nzj{m<717:A,s>1865:A,A}\r\ntp{a<2510:R,R}\r\nzxn{x>912:A,a<3357:A,R}\r\nsgv{x<2978:gqv,a<3171:mh,A}\r\nphh{s<742:lmb,s<1213:sn,a>3030:ltt,A}\r\nndv{a<2330:tg,gfc}\r\ncsf{x<1891:jj,a>3261:nhd,npf}\r\ndbb{s<481:R,s>844:A,R}\r\nrs{x>3107:R,m>1855:A,a<2229:R,A}\r\ngzd{s<1744:A,a<633:R,A}\r\nqc{m<2912:tb,a>854:kxs,R}\r\nxs{a<2120:R,R}\r\nsl{s<3478:A,R}\r\ndn{a>895:lzj,tk}\r\ncb{m<858:R,x>825:R,x<677:A,A}\r\nzss{m<3545:R,a>3827:R,x<3685:R,R}\r\ncn{x<2843:qr,a<1074:kg,zfd}\r\nxrx{s<2168:R,a>611:A,R}\r\ngq{x>3302:jl,x>3237:R,pg}\r\nzkg{a<2049:R,m<1016:R,s<3848:R,R}\r\nvbb{x<3464:R,R}\r\nlgq{x>3381:R,s<1089:R,R}\r\ncf{m<863:xp,R}\r\nbjl{m>1676:xg,s>3264:cf,s<2873:gl,cg}\r\njl{a>2645:R,a<2272:A,R}\r\ngkj{x>3097:lh,m>3723:fxv,R}\r\nhgx{a<2317:zh,bz}\r\ngl{m<669:R,rm}\r\njc{a<940:R,R}\r\nzc{s>3283:vn,s>2491:R,dd}\r\nmk{a>932:A,s>2605:qft,s<2591:rrb,R}\r\nlm{a>3182:A,m>807:R,A}\r\ncrq{s<1950:fpb,vzs}\r\nft{m<228:vs,m>362:txl,qhh}\r\nqmn{x>3417:A,s<724:A,s<1577:R,rmg}\r\nffb{s<3279:rlr,xpf}\r\nzfd{m<612:A,m>1076:R,R}\r\ndtq{m<2745:R,R}\r\nbzr{x>3390:bp,R}\r\nkr{x>3517:cnn,a<1807:ghb,s>2518:cj,ld}\r\ngj{m<1613:kr,cm}\r\nmt{x<3132:R,dnh}\r\nnvs{m>1916:A,A}\r\nqrt{x>3293:R,m>244:R,a<2764:R,R}\r\ntjh{s<3024:R,s<3504:kcz,a>2172:tc,fvz}\r\nxcv{s<853:mck,x>2933:bvq,a>1527:ngt,sz}\r\nlgs{m<3122:R,R}\r\nzg{s<3119:jr,zcc}\r\nznx{s<821:R,x>407:R,A}\r\nbp{s<1466:R,a<2822:R,m<2517:R,A}\r\ndd{a<2900:A,R}\r\nrbg{s<2594:nc,hh}\r\nkc{x>228:R,R}\r\nnts{x<2171:nl,ds}\r\nsjh{m>262:R,x<3320:kh,A}\r\nfv{x<974:A,a>1329:vd,x>1154:dz,dtq}\r\nnp{m>2901:zxn,s<1894:A,s<2229:A,xn}\r\nmr{s>2671:lfb,s<2379:fb,s>2568:mk,tz}\r\nhfv{a<1246:gls,s<1496:jzz,zg}\r\nzmx{a<3168:ff,A}\r\nvkz{s>2647:A,s>2206:R,R}\r\nfth{x<3911:bjg,pch}\r\njn{m>3853:R,x>3385:R,R}\r\nsd{x>3775:R,s>2449:cz,a<405:A,rnz}\r\nqv{a<1021:R,s<2252:R,R}\r\nffl{m>1027:R,R}\r\nzzs{s>1866:R,m<3209:A,m<3609:A,A}\r\nhsf{s>1476:R,R}\r\nthg{s>3652:R,s<3508:R,x>1068:hr,mzk}\r\nkg{x>2965:lvs,x>2887:A,x<2860:bpf,pqv}\r\nnx{x<2779:A,s>2164:R,m>438:R,R}\r\nmd{m>701:R,s>3344:cth,a>2599:qrt,bcf}\r\nxx{x>1273:qm,tv}\r\ngtv{a>3261:R,A}\r\nnq{s>2860:hp,R}\r\ntz{a>689:jjj,a<372:A,cjf}\r\nsrz{m<331:nqx,a<1166:sd,bx}\r\nnf{a<2077:R,x>3322:A,R}\r\nmh{x<3013:A,m<2292:R,a>2375:R,R}\r\nqzt{s<938:A,x<2719:R,m<1478:R,R}\r\nkb{a>3541:A,A}\r\nlvt{a<2737:R,x>3246:A,R}\r\nqlh{m>2051:vll,R}\r\nvn{a<2909:R,A}\r\nrtm{a<1680:bfv,R}\r\njzh{a<3240:R,x>3271:R,a<3499:A,A}\r\nssg{a>2380:lf,s>370:A,A}\r\nglv{s<1131:A,R}\r\nbkf{a<2591:R,a>2676:R,x<350:R,R}\r\nxhx{x<855:R,m<766:A,A}\r\nbqg{x>3272:A,x>3214:R,a<3112:A,A}\r\nbc{x<156:A,a>934:R,m<2168:R,R}\r\nrl{m>3333:R,a<2865:R,R}\r\ncth{m<397:A,A}\r\nrx{x>1610:A,m>3500:A,a>2000:R,R}\r\ntj{s>979:rp,R}\r\nprm{x>3770:R,R}\r\nfhd{m>1529:R,R}\r\nrdq{m<3743:A,m>3890:R,m>3836:R,A}\r\nsvr{s<1277:A,R}\r\nrxb{a<2065:A,m<619:R,R}\r\njkm{a<2967:A,R}\r\nnpf{x<2238:R,R}\r\nhgj{s>3122:A,a<3097:jkm,x>3627:lv,A}\r\nmx{a>1554:pfn,m<437:pxv,x<3296:R,A}\r\ntfx{x<992:A,x<1093:pq,a>2544:lgr,A}\r\npq{a>2392:A,A}\r\nvcg{s>1038:R,a<499:A,R}\r\nbq{x>3320:xk,kvk}\r\nmzk{s>3568:A,x<853:R,R}\r\nkbk{s<3343:A,R}\r\nlhn{x>2868:R,s<838:R,R}\r\ncql{s<732:R,A}\r\nnvq{x>2634:zht,A}\r\nhqg{a>2554:A,R}\r\nrrb{m>2127:A,x>2881:R,A}\r\ngqt{s<2499:A,s<2623:A,a>3424:R,R}\r\ncsh{a>624:R,s<1599:tt,m>1434:A,R}\r\npnk{m<2982:R,m>3177:A,R}\r\nxg{s<3449:sh,a<1459:R,s>3790:A,hq}\r\ngd{a<763:R,a>1542:A,A}\r\ngtg{s>1721:pnk,s<1544:A,fgr}\r\njcv{s>2830:A,x>3291:R,R}\r\nhrh{m>3490:jlm,mp}\r\nbxn{s>3078:R,A}\r\nxbb{m>3000:R,m<2557:R,a<3329:A,A}\r\njzn{s>2306:R,x<2986:R,a>2949:A,A}\r\ncbz{m<2452:R,m>2653:A,m>2537:R,A}\r\nzbt{x>273:ms,x>109:zmx,hpb}\r\nctj{m<1790:frz,x>2123:mbm,R}\r\npcp{s<3380:A,m>1195:A,x>2990:A,R}\r\njhc{s<2482:jsx,R}\r\ncz{m>653:R,x>3649:A,A}\r\nbfv{s<548:A,a>638:R,a>396:A,A}\r\nspr{a>3678:R,x<1552:A,x>1735:A,A}\r\nvr{a>3020:R,R}\r\nms{m<2429:A,a>3099:R,x>425:nkc,rl}\r\ntnn{a>3093:R,A}\r\nqtq{a>912:R,a>597:R,R}\r\njct{x>3362:R,m>1030:A,m<883:R,R}\r\nbvq{s<1295:dzb,jtp}\r\nlls{x>2726:A,a<2507:R,x<2648:A,R}\r\ntn{x>951:A,nrz}\r\ncr{m<1004:R,x<1025:R,R}\r\nvll{m>2293:A,m>2192:A,A}\r\ndv{m<1039:jm,A}\r\ntt{m>862:A,R}\r\nlcv{s>1479:A,x<3886:zl,s<952:A,rv}\r\ngt{m<1480:R,jfs}\r\ngqv{s>3635:A,A}\r\nkqz{s>3214:A,A}\r\nsx{x>787:A,R}\r\ntg{a>1450:R,x>3694:A,s>1757:R,A}\r\nhvc{x<578:xck,m<2269:hfv,ng}\r\nmg{x<1565:A,A}\r\nlvq{x>3284:R,s>3217:R,A}\r\nkrr{a<3777:kc,x<239:A,A}\r\nhb{x<2694:js,vm}\r\nbx{a<1924:R,ljq}\r\njzz{a<1738:cb,s>901:xhx,a>1962:R,R}\r\nrr{s>896:A,R}\r\nqcg{a<2516:R,R}\r\nkxs{x>840:A,x<747:A,a>1356:A,A}\r\nlfj{s<2038:zb,m<3166:gff,a>3183:xl,cc}\r\ngqd{s>864:R,a<2993:R,a<3181:R,A}\r\ndkd{x>2780:R,m<441:A,A}\r\nbjf{m>1394:R,a>2548:A,A}\r\nch{m>3354:xjg,bmk}\r\nvc{x>267:txp,x>173:gt,jlf}\r\njx{a<256:lgm,R}\r\ngfb{x<3822:A,m>2902:zgd,x<3888:cbz,R}\r\npk{s<1524:R,s<2065:A,a>3212:ffr,R}\r\nsm{m>974:pbr,A}\r\njgl{m<2296:zcl,a>914:zzs,a<482:R,gzd}\r\nnhd{a<3391:A,A}\r\nrm{x<2052:R,A}\r\nhpb{x>65:R,a>3263:cql,s<699:sxj,dkt}\r\nxmg{a>1190:sk,a<652:jx,s>2015:qtr,kp}\r\nfvb{s<2321:R,x>3359:R,R}\r\ngqk{a<2630:R,A}\r\nzvr{s>1828:R,x<3360:bqg,a>2878:vbb,tp}\r\ncc{x>3643:trm,bn}\r\nqj{a>3458:mq,ln}\r\npb{a<2589:A,a>2846:A,m<652:A,A}\r\nkz{x<3313:A,R}\r\nfhq{a<2306:bjl,a<3115:xf,s>3112:ccd,gf}\r\nxdb{x<1943:xbb,s>3562:R,A}\r\nxn{x<892:A,a<3291:A,x>1048:R,A}\r\ndqf{x>3370:A,A}\r\njfs{a>3339:R,a>3124:R,A}\r\nxlf{x<3542:xsq,prm}\r\nhq{s<3606:A,s<3671:A,R}\r\nmn{x<3346:R,R}\r\nhj{a<2854:fz,A}\r\nbjg{s<1680:A,R}\r\nbz{x<2925:A,s<2864:gqt,kbk}\r\nllm{x<2811:qcg,x>2864:R,a>2745:A,R}\r\ndq{x>3350:knc,lvq}\r\ngn{x>3784:R,a<2766:gqk,xxp}\r\nvs{s<2568:jzn,x>2977:A,R}\r\nmnv{m>2422:fk,x<3599:R,a<3471:A,R}\r\nqhh{x<2968:ljg,R}\r\nmsk{a<1922:R,cs}\r\nrnz{m>540:R,R}\r\nxgp{a>1935:R,a>1818:dkd,a<1776:A,A}\r\nqhv{a>998:A,a<593:A,hzm}\r\ngf{x>1860:nts,a<3480:nq,s>2782:jd,zs}\r\nnrz{m>3457:R,R}\r\npt{m>2776:R,A}\r\npbr{a>3065:R,x>3090:A,m>1827:R,R}\r\nzb{x>3484:lgs,a>3470:bv,R}\r\nfpb{a<2199:dn,x>2822:fq,ssd}\r\nbv{s>795:A,s>510:R,A}\r\nvnf{m>1189:A,A}\r\nlv{m<3761:A,A}\r\nhv{x<3464:A,A}\r\nffg{m>2301:bkf,bjf}\r\nsk{s>1830:rhg,m<935:R,m<1717:R,qp}\r\nznr{x>319:dj,m<1775:R,m>2856:xcq,bc}\r\njtp{m<1284:R,R}\r\nbj{x>2041:dt,s>2024:R,m>2936:rx,R}\r\nrv{m>1140:R,s>1291:R,x>3930:A,R}\r\ngkz{m<3746:A,x>2666:A,R}\r\nprv{x>1656:A,x>1447:R,m<1940:A,R}\r\ndnh{s>2788:A,R}\r\nqq{x>72:R,A}\r\nvb{a<2857:rds,x<2718:R,A}\r\ndj{s>419:A,a>928:R,x>421:R,R}\r\nrc{a<1146:jct,R}\r\nbb{a>2075:zc,bzx}\r\njm{m<919:A,R}\r\njj{m<1067:R,a<3369:A,R}\r\nsmb{a>645:R,qzt}\r\nlr{x>3337:thl,x>3276:A,x<3223:vr,lm}\r\nrq{a<3448:rdq,A}\r\nnsx{a>318:fvb,jk}\r\ndqd{m<3010:jzr,x>3543:hrh,s<2149:qmn,cl}\r\nvzs{m<3264:ffb,x<2813:bb,x>3004:jp,hgx}\r\ncg{a<1077:A,m>680:A,s>3091:R,R}\r\nthl{a<2939:R,m>836:R,R}\r\nlfb{s<3163:cxt,zbc}\r\nhk{m>1305:lmt,s<1042:R,x<3332:jzh,vnf}\r\nlmb{s>392:A,x>3497:R,R}\r\nkp{s>1605:cgx,a<869:A,A}\r\nrmg{m>3471:A,a>1987:R,A}\r\ncj{a<3154:xpd,qj}\r\nhjh{s>438:ndp,x<2990:R,R}\r\nlzj{m<3379:rbq,s<1060:R,a<1413:R,R}\r\nxt{x>3666:sq,s>3083:A,m<1802:R,R}\r\nxr{a<2655:sv,s>449:gqd,R}\r\npj{x<1807:R,s<3030:dm,fx}\r\nhp{a>3286:R,x>1486:R,A}\r\nppq{s>374:A,A}\r\nxpd{a<2339:stf,a>2848:ll,md}\r\nbdj{m<1473:R,a<2491:A,x>1144:R,A}\r\nfn{a<3456:A,R}\r\nlmt{a<3104:A,R}\r\nsdc{m<660:R,R}\r\nqb{x>3231:R,A}\r\nds{x<2355:R,A}\r\nhcv{m<452:R,R}\r\ncgx{s<1866:A,x>1983:R,a>849:A,R}\r\nndp{x>2968:A,m<2909:A,A}\r\nnl{s<2686:R,m<1818:A,m<3153:A,A}\r\nrp{a>3751:A,s>1387:A,x>3721:R,A}\r\nrgg{m>944:R,s<1930:vcp,m>413:mg,bpr}\r\njsx{x<2639:R,a<2210:A,m>949:R,R}\r\nffr{a<3563:A,x>3419:A,a>3749:R,A}\r\nnxp{m<571:hsf,m<1063:lsg,m<1247:A,lls}\r\ntmh{m>2732:A,A}\r\ngfc{x>3656:R,s>1835:R,R}\r\njvl{s>3628:A,A}\r\ndgp{a<3391:R,R}\r\n\r\n{x=2646,m=48,a=1018,s=1619}\r\n{x=1480,m=59,a=1760,s=1135}\r\n{x=1941,m=1032,a=142,s=649}\r\n{x=1907,m=2539,a=281,s=336}\r\n{x=213,m=582,a=580,s=17}\r\n{x=155,m=143,a=132,s=1308}\r\n{x=416,m=273,a=23,s=644}\r\n{x=79,m=2684,a=253,s=1159}\r\n{x=497,m=487,a=25,s=137}\r\n{x=164,m=1363,a=231,s=1700}\r\n{x=1048,m=973,a=324,s=644}\r\n{x=13,m=506,a=537,s=53}\r\n{x=91,m=73,a=1971,s=1389}\r\n{x=95,m=779,a=33,s=721}\r\n{x=1271,m=2950,a=400,s=2398}\r\n{x=156,m=238,a=2122,s=879}\r\n{x=1296,m=31,a=33,s=1510}\r\n{x=313,m=1933,a=1784,s=2099}\r\n{x=1084,m=160,a=594,s=874}\r\n{x=1653,m=778,a=1034,s=1402}\r\n{x=1412,m=234,a=125,s=755}\r\n{x=1449,m=306,a=1191,s=267}\r\n{x=588,m=1776,a=103,s=1945}\r\n{x=1595,m=1437,a=2326,s=381}\r\n{x=1856,m=1840,a=71,s=1539}\r\n{x=893,m=141,a=141,s=952}\r\n{x=381,m=152,a=524,s=3098}\r\n{x=353,m=1360,a=255,s=1245}\r\n{x=5,m=701,a=1693,s=18}\r\n{x=582,m=1159,a=531,s=172}\r\n{x=313,m=965,a=1451,s=326}\r\n{x=118,m=554,a=1967,s=2126}\r\n{x=1421,m=1872,a=1181,s=259}\r\n{x=422,m=985,a=2544,s=1024}\r\n{x=209,m=572,a=1937,s=1325}\r\n{x=3126,m=9,a=826,s=1902}\r\n{x=2531,m=686,a=283,s=166}\r\n{x=977,m=817,a=2938,s=474}\r\n{x=2798,m=1645,a=1595,s=295}\r\n{x=2161,m=1035,a=833,s=2412}\r\n{x=78,m=915,a=133,s=723}\r\n{x=219,m=1807,a=1086,s=226}\r\n{x=101,m=1096,a=2766,s=772}\r\n{x=84,m=754,a=66,s=495}\r\n{x=5,m=536,a=534,s=800}\r\n{x=953,m=989,a=1141,s=318}\r\n{x=1398,m=24,a=1746,s=19}\r\n{x=2903,m=2068,a=1702,s=314}\r\n{x=212,m=170,a=726,s=1334}\r\n{x=1149,m=72,a=11,s=2276}\r\n{x=1201,m=244,a=630,s=1717}\r\n{x=86,m=315,a=733,s=1001}\r\n{x=5,m=35,a=167,s=303}\r\n{x=14,m=1493,a=1081,s=465}\r\n{x=1,m=556,a=2714,s=1624}\r\n{x=1,m=128,a=293,s=1632}\r\n{x=406,m=1978,a=178,s=272}\r\n{x=118,m=1671,a=34,s=731}\r\n{x=1853,m=245,a=271,s=52}\r\n{x=2202,m=1229,a=1043,s=1275}\r\n{x=2324,m=1514,a=1298,s=270}\r\n{x=372,m=395,a=1095,s=1383}\r\n{x=1492,m=723,a=1279,s=446}\r\n{x=2181,m=3750,a=1937,s=2951}\r\n{x=82,m=1380,a=3640,s=354}\r\n{x=422,m=3067,a=238,s=101}\r\n{x=2189,m=245,a=2637,s=1146}\r\n{x=444,m=117,a=139,s=498}\r\n{x=1111,m=2172,a=76,s=93}\r\n{x=1040,m=150,a=2152,s=857}\r\n{x=436,m=1393,a=3218,s=156}\r\n{x=1189,m=278,a=2371,s=83}\r\n{x=1236,m=413,a=1814,s=1152}\r\n{x=196,m=160,a=1452,s=587}\r\n{x=1366,m=26,a=35,s=464}\r\n{x=10,m=1110,a=84,s=852}\r\n{x=2216,m=1831,a=2161,s=569}\r\n{x=1439,m=1,a=320,s=1722}\r\n{x=1189,m=226,a=376,s=2111}\r\n{x=1294,m=696,a=1112,s=434}\r\n{x=2055,m=2629,a=1411,s=80}\r\n{x=2498,m=841,a=130,s=1108}\r\n{x=85,m=3212,a=112,s=983}\r\n{x=3543,m=1752,a=455,s=1369}\r\n{x=33,m=3113,a=633,s=32}\r\n{x=176,m=1001,a=2080,s=1935}\r\n{x=1282,m=320,a=167,s=2733}\r\n{x=1940,m=159,a=356,s=27}\r\n{x=705,m=481,a=257,s=1752}\r\n{x=719,m=411,a=1536,s=330}\r\n{x=1045,m=90,a=60,s=266}\r\n{x=148,m=502,a=2549,s=1904}\r\n{x=199,m=43,a=1324,s=17}\r\n{x=3042,m=811,a=2606,s=219}\r\n{x=186,m=412,a=53,s=353}\r\n{x=94,m=1271,a=1950,s=67}\r\n{x=2631,m=1728,a=1573,s=153}\r\n{x=3,m=210,a=1542,s=1650}\r\n{x=665,m=1737,a=176,s=219}\r\n{x=398,m=393,a=1587,s=2415}\r\n{x=348,m=1461,a=265,s=1192}\r\n{x=448,m=1036,a=1115,s=107}\r\n{x=881,m=1086,a=939,s=1185}\r\n{x=1,m=737,a=1404,s=142}\r\n{x=661,m=1549,a=1566,s=1258}\r\n{x=526,m=3293,a=597,s=406}\r\n{x=2120,m=1010,a=619,s=3058}\r\n{x=2996,m=352,a=1692,s=852}\r\n{x=196,m=558,a=2470,s=52}\r\n{x=3315,m=258,a=699,s=508}\r\n{x=787,m=732,a=2235,s=34}\r\n{x=332,m=390,a=183,s=583}\r\n{x=743,m=190,a=406,s=139}\r\n{x=2764,m=1636,a=2897,s=105}\r\n{x=41,m=1436,a=1885,s=501}\r\n{x=1958,m=1469,a=2482,s=272}\r\n{x=752,m=1267,a=909,s=2629}\r\n{x=1167,m=108,a=1220,s=1043}\r\n{x=1029,m=154,a=1880,s=653}\r\n{x=1554,m=634,a=522,s=661}\r\n{x=699,m=573,a=1616,s=481}\r\n{x=2340,m=656,a=1597,s=1562}\r\n{x=316,m=2501,a=229,s=1007}\r\n{x=875,m=42,a=3551,s=1825}\r\n{x=1156,m=2038,a=13,s=540}\r\n{x=76,m=900,a=607,s=1092}\r\n{x=2680,m=219,a=1446,s=168}\r\n{x=747,m=422,a=1626,s=1470}\r\n{x=3323,m=666,a=2561,s=1266}\r\n{x=682,m=540,a=554,s=180}\r\n{x=529,m=35,a=120,s=936}\r\n{x=1722,m=1177,a=2177,s=1238}\r\n{x=2533,m=443,a=110,s=674}\r\n{x=106,m=205,a=2205,s=287}\r\n{x=2632,m=158,a=17,s=430}\r\n{x=2225,m=2002,a=813,s=1476}\r\n{x=1025,m=1383,a=2434,s=112}\r\n{x=826,m=1107,a=681,s=787}\r\n{x=708,m=641,a=748,s=1004}\r\n{x=1482,m=1135,a=69,s=266}\r\n{x=596,m=1729,a=207,s=1778}\r\n{x=250,m=827,a=1333,s=1000}\r\n{x=2053,m=274,a=1781,s=138}\r\n{x=68,m=628,a=849,s=140}\r\n{x=1753,m=2469,a=257,s=950}\r\n{x=27,m=112,a=204,s=2145}\r\n{x=654,m=702,a=340,s=2178}\r\n{x=1453,m=1151,a=87,s=862}\r\n{x=126,m=3343,a=44,s=1886}\r\n{x=112,m=1388,a=1101,s=900}\r\n{x=2037,m=1169,a=1554,s=2091}\r\n{x=774,m=649,a=348,s=541}\r\n{x=862,m=1986,a=163,s=814}\r\n{x=85,m=13,a=1279,s=659}\r\n{x=521,m=294,a=517,s=501}\r\n{x=64,m=2828,a=1225,s=1054}\r\n{x=1983,m=254,a=1284,s=2125}\r\n{x=129,m=1296,a=267,s=347}\r\n{x=852,m=925,a=2136,s=1209}\r\n{x=1137,m=71,a=2835,s=379}\r\n{x=202,m=759,a=2932,s=1971}\r\n{x=1398,m=184,a=3218,s=418}\r\n{x=1772,m=230,a=86,s=1026}\r\n{x=1695,m=2056,a=681,s=1483}\r\n{x=127,m=2193,a=3390,s=261}\r\n{x=2411,m=666,a=292,s=215}\r\n{x=941,m=1256,a=971,s=94}\r\n{x=241,m=2596,a=317,s=1970}\r\n{x=75,m=19,a=856,s=629}\r\n{x=1593,m=369,a=195,s=39}\r\n{x=61,m=688,a=546,s=3324}\r\n{x=460,m=2409,a=675,s=59}\r\n{x=2696,m=2425,a=1183,s=3328}\r\n{x=43,m=102,a=896,s=983}\r\n{x=1055,m=445,a=912,s=1090}\r\n{x=1733,m=977,a=170,s=497}\r\n{x=978,m=95,a=594,s=105}\r\n{x=3247,m=147,a=1282,s=119}\r\n{x=2032,m=882,a=74,s=1028}\r\n{x=30,m=2017,a=1965,s=1701}\r\n{x=425,m=162,a=1624,s=77}\r\n{x=513,m=18,a=395,s=148}\r\n{x=2176,m=1267,a=757,s=841}\r\n{x=805,m=1062,a=1008,s=759}\r\n{x=86,m=215,a=30,s=1024}\r\n{x=191,m=2760,a=108,s=320}\r\n{x=853,m=32,a=699,s=868}\r\n{x=2365,m=730,a=1893,s=920}\r\n{x=172,m=62,a=244,s=3137}\r\n{x=2716,m=1192,a=2443,s=3036}\r\n{x=2083,m=358,a=980,s=2170}\r\n{x=1221,m=428,a=410,s=115}\r\n{x=2771,m=350,a=2291,s=2288}\r\n{x=822,m=243,a=68,s=2121}\r\n{x=522,m=203,a=2670,s=10}\r\n{x=5,m=554,a=797,s=345}\r\n{x=2784,m=3282,a=1543,s=685}\r\n{x=811,m=1857,a=708,s=1757}\r\n{x=874,m=64,a=631,s=2416}\r\n{x=472,m=796,a=2160,s=343}";
            string demo1 = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";
            string demo2 = "in{A}";


            string temp = input;

            string workflowsString = temp.Split("\r\n\r\n")[0];
            string startId = "in";
            long total = 0;
            long notTotal = 0;

            Dictionary<string, Workflow> workflows = new Dictionary<string, Workflow>();

            string[] workflowArr = workflowsString.Split("\r\n");

            foreach (string workflow in workflowArr)
            {
                string workflowId = workflow.Split('{')[0];
                string workflowChecks = workflow.Split('{')[1].Replace("}", "");

                Workflow newWorkflow = new Workflow();

                string[] checkArr = workflowChecks.Split(",");

                foreach (string check in checkArr)
                {
                    Check newCheck = new Check();

                    if (checkArr.Last() == check)
                    {
                        newCheck.reference = 'x';
                        newCheck.comparer = '>';
                        newCheck.value = -1;
                        newCheck.doNext = check;
                    }
                    else
                    {
                        newCheck.reference = check[0];
                        newCheck.comparer = check[1];
                        newCheck.value = Convert.ToInt32(check.Split(':')[0].Substring(2));
                        newCheck.doNext = check.Split(':')[1];
                    }

                    newWorkflow.checks.Add(newCheck);
                }

                workflows.Add(workflowId, newWorkflow);
            }


            List<Dictionary<char, int[]>> possibleRatingList = new List<Dictionary<char, int[]>>();
            Dictionary<char, int[]> startDic = new Dictionary<char, int[]>();
            startDic.Add('x', [1, 4000]);
            startDic.Add('m', [1, 4000]);
            startDic.Add('a', [1, 4000]);
            startDic.Add('s', [1, 4000]);

            possibleRatingList.Add(startDic);

            List<Dictionary<char, int[]>> nextPossibleRatingList = new List<Dictionary<char, int[]>>();

            do
            {
                foreach (var possibleRating in possibleRatingList)
                {
                    string moveTo = startId;
                    bool checkOutcome = false;

                    do
                    {
                        Workflow thisWorkflow = workflows[moveTo];

                        foreach (var check in thisWorkflow.checks)
                        {
                            checkOutcome = false;

                            char splitOn = check.reference;

                            Dictionary<char, int[]> newDic = new Dictionary<char, int[]>();

                            newDic.Add('x', [possibleRating['x'][0], possibleRating['x'][1]]);
                            newDic.Add('m', [possibleRating['m'][0], possibleRating['m'][1]]);
                            newDic.Add('a', [possibleRating['a'][0], possibleRating['a'][1]]);
                            newDic.Add('s', [possibleRating['s'][0], possibleRating['s'][1]]);


                            switch (check.comparer)
                            {
                                case '<':
                                    if (possibleRating[splitOn][1] >= check.value && possibleRating[splitOn][0] < check.value)
                                    {
                                        newDic[splitOn][0] = check.value;
                                        possibleRating[splitOn][1] = check.value - 1;
                                        nextPossibleRatingList.Add(newDic);
                                    }

                                    if (possibleRating[splitOn][1] < check.value)
                                    {
                                        checkOutcome = true;
                                    }


                                    break;
                                case '>':

                                    if (possibleRating[splitOn][0] <= check.value && possibleRating[splitOn][1] > check.value)
                                    {
                                        newDic[splitOn][0] = check.value + 1;
                                        possibleRating[splitOn][1] = check.value;
                                        nextPossibleRatingList.Add(newDic);
                                    }

                                    if (possibleRating[splitOn][0] > check.value)
                                    {
                                        checkOutcome = true;
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Something went wrong @ compairer switch");
                                    break;
                            }

                            if (checkOutcome)
                            {
                                moveTo = check.doNext;
                                break;
                            }

                        }
                        if (moveTo == "R" || moveTo == "A")
                        {
                            long thisTotal = 1;
                            foreach (var x in possibleRating.Values)
                            {
                                thisTotal *= (x[1] - x[0] + 1);
                            }

                            if (moveTo == "A")
                            {
                                total += thisTotal;
                                break;
                            }
                            notTotal += thisTotal;
                            break;
                        }

                    } while (true);


                }

                possibleRatingList.Clear();
                possibleRatingList.AddRange(nextPossibleRatingList);
                nextPossibleRatingList.Clear();

            } while (possibleRatingList.Count > 0);


            Console.WriteLine(total);
            Console.WriteLine(total + notTotal);
        }
        void Part1()
        {
            string input = "qbl{m<1574:A,R}\r\nspp{a<2917:znm,a>3411:hqz,a<3171:sm,mt}\r\nhr{m>2184:R,R}\r\nts{m<252:R,m<371:R,a>3579:A,fn}\r\njqx{a>2040:csq,nxz}\r\nqft{x>2939:R,R}\r\nnm{a<2683:A,R}\r\nstf{x<3354:R,s<3146:rxb,R}\r\nsz{s>1324:csh,s>1102:qhv,smb}\r\nqm{s<2419:tf,fhq}\r\nln{s<3452:sdc,s>3806:R,a>3329:mn,gtv}\r\nsv{m<2846:A,s>805:R,R}\r\nmrb{s<892:A,A}\r\njtg{m>1009:pkt,a<3010:lzx,sp}\r\njq{x>3362:pk,x<3274:zxr,sjh}\r\nvhl{a<3085:R,A}\r\nlgm{s<1828:R,m<1467:R,s>2175:R,A}\r\npkh{a>2156:R,a>1190:R,R}\r\nmtk{s>339:A,m>545:A,R}\r\nvf{x>3575:gn,bzr}\r\nrlr{s<2506:R,pkh}\r\nzq{a>892:jcv,R}\r\nvp{x<3837:zj,m<702:A,A}\r\nhh{s>3225:thg,sjz}\r\nlfg{m>3773:dbb,s>721:R,ppq}\r\nzcl{a<1277:A,m>1478:R,A}\r\nmxn{m<3702:zss,s>2616:R,s>1078:vhh,R}\r\nng{s>1410:qc,m<3268:fv,m<3580:tn,lfg}\r\ntcq{x>3342:A,a<2914:R,s>3111:R,A}\r\njs{x>2628:smq,x>2608:A,vhl}\r\nqp{s<1594:R,x>1781:R,A}\r\nsxj{s>387:R,m<1853:A,R}\r\nrdk{m<1026:rtm,xq}\r\nzh{a<889:bxn,qpb}\r\nhz{x<2951:A,R}\r\nchm{x<3403:A,x<3456:tmh,R}\r\nrds{a>2494:A,A}\r\nnk{s<1558:R,A}\r\nzv{s>1894:fqt,lrt}\r\nrb{s>1278:zvr,m<1005:lr,s>621:hk,gq}\r\njxq{x<3571:lgq,s<720:R,R}\r\nxf{a<2719:pj,a<2885:hfd,ctj}\r\nklx{x<3699:R,m>3744:A,x>3898:A,A}\r\nfgr{m>3061:A,x<3000:A,A}\r\nbzx{m>3605:gkz,m>3474:A,mpt}\r\nlh{s>2838:R,s>2364:R,a>3340:A,R}\r\ncm{a<2481:jkn,m>2949:szf,a<3313:zkv,zv}\r\nddv{a<2893:R,R}\r\nbn{s<3160:R,x>3364:R,A}\r\nrbq{a>1335:R,s<1190:R,x>2922:R,R}\r\nzht{m>2105:R,s<2964:R,a>2355:A,R}\r\nqpb{a<1387:A,s<2729:A,R}\r\nfvz{x>2841:R,m<1023:R,A}\r\nhzm{m>1472:R,a>832:R,s<1216:A,R}\r\nssz{x>3330:glv,R}\r\nnh{x<2958:lhn,htg}\r\ndvb{a<814:frh,x<3522:chm,gfb}\r\nxjg{a<2980:A,R}\r\ncxt{s<2875:R,x>2821:R,R}\r\nngt{s<1276:hj,s>1582:llm,m<1387:nxp,tnn}\r\nlgr{x>1156:R,a<2652:A,a>2752:R,A}\r\ngls{s<1517:vdr,s>3140:cr,R}\r\ndkt{a<3070:A,R}\r\nsqp{x>3128:A,a>3717:A,A}\r\ntrm{x<3807:A,x>3932:R,s>2867:R,A}\r\nfxv{x<3060:A,m<3872:R,m<3957:R,R}\r\nsc{m>2545:crq,mkl}\r\ntf{m>2267:nhb,s<1269:rdk,a<2660:xmg,hd}\r\nbmk{m<2909:R,R}\r\nff{x<166:R,m>1657:R,x<203:A,A}\r\nddg{s<3171:vkz,m<2032:hnj,sgv}\r\nkvk{a<730:qb,s>2582:A,s<1642:A,R}\r\nvdr{a>732:R,A}\r\nzbc{s>3491:A,s>3354:R,A}\r\nmq{m>879:A,s>3182:kz,R}\r\nkh{x>3303:R,R}\r\nsn{a<3085:R,x<3638:R,a<3223:R,R}\r\nfx{s<3365:A,s<3768:A,x<2290:A,A}\r\nzl{m<1180:A,A}\r\nsrj{s<2766:R,R}\r\nsjz{a>2925:R,x<904:A,s>2888:pcb,bdj}\r\nfq{m>3351:nh,s<964:hjh,s>1387:gtg,hz}\r\ncrb{m<1900:A,s<970:R,a<3511:R,A}\r\nzx{m<1529:cn,mr}\r\nfz{m>853:A,A}\r\ncl{m<3570:nf,s>3104:jn,A}\r\nxsj{a>1327:R,R}\r\ngz{s>2087:xt,a>2786:phh,jxq}\r\nsr{a<686:nsx,s>2475:dv,rc}\r\ngv{m<1324:R,R}\r\nrnf{x<360:R,vg}\r\nljq{a>2095:R,a<1982:A,a>2041:A,A}\r\nsq{a<2885:R,A}\r\nrlp{a>3714:mxn,rq}\r\nhfd{s>3346:nj,R}\r\nnd{a<920:A,A}\r\nhnj{a<2808:A,x>2971:R,s<3552:A,A}\r\njlm{m<3824:A,R}\r\nxck{s>2449:jc,s>1262:jgl,s>736:qbl,znr}\r\njjn{m>2086:lt,krr}\r\njp{a<2407:bkh,gkj}\r\nszf{m<3345:lfj,a>3306:rlp,a>2761:zrq,rfr}\r\nqvt{m>2876:R,x>908:R,x>766:A,R}\r\npfn{s<3150:A,m<268:R,m<465:A,R}\r\nkq{s<3578:A,A}\r\nld{m>632:rb,jq}\r\nfg{a<1947:gd,x<2011:R,A}\r\npcb{s>3005:R,m>2426:R,A}\r\nmqv{s<2651:A,A}\r\nzp{m<3217:R,A}\r\nbpr{a<3504:A,s<2171:A,A}\r\nnks{s<2655:nx,x>2777:sl,jzt}\r\nzxr{x>3230:lvt,A}\r\nlzx{x<2988:R,x<3006:pb,mqv}\r\nhqz{m<910:sqp,a>3760:R,a<3608:R,klp}\r\nzrq{s<1965:xlf,hgj}\r\ngff{a>3296:A,m>3091:A,x>3604:R,lzz}\r\nsp{s<3082:dgp,s>3562:R,R}\r\nvck{a>3564:R,s>1343:A,R}\r\ntc{x<2801:A,R}\r\ncnn{m>836:ggb,a<2366:srz,kxz}\r\nvm{a<3067:ffl,m>1054:R,R}\r\nklp{m<1643:A,s>3100:A,A}\r\nzs{s<2623:prv,R}\r\nxsq{a<3078:A,x>3368:A,A}\r\nggb{x<3799:ndv,a<1843:lcv,a<2735:gv,fth}\r\nsmq{m>1630:A,a>3389:R,m<889:A,A}\r\njlf{s<2601:qq,A}\r\nmkl{s<1824:xcv,a<1755:zx,x>2924:xh,lg}\r\njkn{a>1538:dqd,s<2181:dvb,lq}\r\nfrh{a<451:hv,x<3680:svr,m<2584:zk,R}\r\nlpc{a<2220:nvs,x>2723:qlh,nvq}\r\nxpr{s<2224:A,R}\r\nhbz{s>742:A,m>2908:A,s>407:A,A}\r\nghb{m<735:zf,m>1232:bq,sr}\r\nqr{a<1056:kf,x>2726:R,x>2659:A,xsj}\r\nljg{a>3202:R,R}\r\nlt{a>3783:R,m<2991:R,znx}\r\nlf{x<2866:A,R}\r\nnkc{a<2896:A,A}\r\njjj{a>1170:A,A}\r\nvcp{a<3476:A,x<1527:R,A}\r\ncs{x<2769:A,A}\r\nxk{m<1429:xj,x<3451:dqf,a<864:R,fhd}\r\ncsq{m>133:R,s>3174:R,s<2646:R,A}\r\ncjf{s<2500:A,x>2966:R,s<2537:R,R}\r\npch{a>3402:R,x<3970:R,A}\r\ndzb{m>1629:lch,x>3070:A,a>1344:R,vcg}\r\npkt{m<1118:A,m>1245:kqz,s<2841:A,pcp}\r\nqtr{x>1871:nd,x>1665:A,m<1246:R,A}\r\nnc{m<1646:mrb,s<1348:gr,a>2803:np,tfx}\r\nxcq{m<3438:A,A}\r\nlq{x>3504:pt,zq}\r\nljs{a<2509:R,R}\r\nkxz{a<3295:hcv,m<456:ts,m<593:vck,vp}\r\nccd{a>3532:jvl,m>2141:xdb,csf}\r\nzzk{a>2448:ffg,rnf}\r\nksf{m<252:jqx,a>2045:nks,s>3221:xgp,msk}\r\ntb{a<884:R,s>3121:R,x>868:A,R}\r\nmpt{a<1121:R,x>2693:A,R}\r\nxxp{m<2396:A,m>2746:R,a>3081:A,R}\r\nzf{s<2583:ssz,a>1125:mx,dq}\r\nltt{m<1914:A,A}\r\njk{s>2586:A,R}\r\nvhh{x<3465:A,a>3842:A,A}\r\nzcc{s>3452:R,a>1752:R,A}\r\nmp{a>2083:A,R}\r\nxq{s>435:rr,R}\r\nxh{x>3037:spp,m>1334:ddg,m>463:jtg,ft}\r\njzr{m>2421:xs,ml}\r\ngr{a<2740:qvt,x>1030:R,sx}\r\njzt{a<2287:R,a>2424:R,R}\r\npqv{m<562:R,a>514:R,R}\r\ntk{x<2906:zm,A}\r\ntv{a<2090:hvc,x>660:rbg,bpk}\r\nll{a>2966:R,x<3296:R,x>3419:ddv,tcq}\r\nssd{s>1230:ch,m>3227:vb,a<3339:xr,hbz}\r\nmck{m<997:mtk,ssg}\r\nmbm{s<3035:A,a<2993:R,s>3381:R,A}\r\nknc{a<717:A,A}\r\nnj{s>3662:R,R}\r\nkt{m<1393:R,R}\r\nzm{m>3077:R,s<1102:R,R}\r\nxp{m<555:R,m<686:R,R}\r\nkcz{m<958:A,s>3307:A,R}\r\nlch{a<2420:A,A}\r\nlsg{m>841:A,a>2937:R,A}\r\nlgg{s<3631:R,zkg}\r\ndt{x>2282:R,s>1907:R,R}\r\nnxz{s<2740:R,x<2788:R,s<3169:R,R}\r\nml{x>3641:R,A}\r\nfk{a<3560:R,R}\r\nbkh{m>3566:gks,R}\r\nvd{s<821:R,R}\r\nzkv{m>2074:vf,gz}\r\ntxl{x>2986:R,A}\r\nxj{m>1331:A,a>607:R,A}\r\nkf{a<649:R,R}\r\nzk{s<899:R,m>2066:R,R}\r\nlvs{a<705:R,a<872:A,s>3101:R,A}\r\nbpk{a<2727:zzk,s>1544:vc,a>3548:jjn,zbt}\r\nznm{s<2638:A,m>1174:rs,R}\r\nfb{x>2811:xrx,m<1973:R,R}\r\nxl{a<3521:A,R}\r\nlrt{a<3626:hc,tj}\r\nrfr{a<2578:xc,x>3692:gxf,nm}\r\ncv{a<3435:R,s<2464:A,a>3715:A,R}\r\ndm{m>2201:R,R}\r\nnhb{s<1451:fg,bj}\r\nin{x<2577:xx,x>3180:gj,sc}\r\nrhg{x<1974:R,x>2182:A,m>829:A,A}\r\nlg{a>2525:hb,m>1244:lpc,m<658:ksf,nz}\r\njd{m>2179:zp,m<1381:spr,m>1732:R,R}\r\ntxp{m>1927:cv,kb}\r\njr{a<1781:A,a>1902:R,A}\r\nhd{x>1750:kt,rgg}\r\ngxf{m<3755:nk,a<2695:A,R}\r\nfrz{x>1759:A,s<3233:A,m<654:R,R}\r\ndz{x<1223:A,m<2655:R,a>644:A,A}\r\nhtg{m<3741:A,m<3868:R,x>3045:A,R}\r\ngks{x>3093:A,m<3813:A,s<3256:R,A}\r\nlzz{m<2999:A,a<2878:R,a>3038:A,R}\r\nbpf{s<3163:R,A}\r\nzgd{a<1196:R,a>1317:R,A}\r\nvg{m<2455:A,a>2304:A,x<541:A,R}\r\nbcf{m>348:A,m<191:A,R}\r\npxv{x<3389:A,m>146:A,m>67:R,A}\r\npg{a<2806:R,x<3213:A,s<272:R,R}\r\nsh{m<3146:A,s>2832:R,x>1900:R,R}\r\nnz{x>2724:tjh,s>3242:lgg,jhc}\r\nfqt{a>3693:srj,mnv}\r\nxpf{m<2849:kq,a>1701:R,qtq}\r\nnqx{m>160:xpr,qv}\r\nxc{a<2525:ljs,s>2083:klx,s<1150:A,hqg}\r\nhc{m<2344:crb,A}\r\nzj{m<717:A,s>1865:A,A}\r\ntp{a<2510:R,R}\r\nzxn{x>912:A,a<3357:A,R}\r\nsgv{x<2978:gqv,a<3171:mh,A}\r\nphh{s<742:lmb,s<1213:sn,a>3030:ltt,A}\r\nndv{a<2330:tg,gfc}\r\ncsf{x<1891:jj,a>3261:nhd,npf}\r\ndbb{s<481:R,s>844:A,R}\r\nrs{x>3107:R,m>1855:A,a<2229:R,A}\r\ngzd{s<1744:A,a<633:R,A}\r\nqc{m<2912:tb,a>854:kxs,R}\r\nxs{a<2120:R,R}\r\nsl{s<3478:A,R}\r\ndn{a>895:lzj,tk}\r\ncb{m<858:R,x>825:R,x<677:A,A}\r\nzss{m<3545:R,a>3827:R,x<3685:R,R}\r\ncn{x<2843:qr,a<1074:kg,zfd}\r\nxrx{s<2168:R,a>611:A,R}\r\ngq{x>3302:jl,x>3237:R,pg}\r\nzkg{a<2049:R,m<1016:R,s<3848:R,R}\r\nvbb{x<3464:R,R}\r\nlgq{x>3381:R,s<1089:R,R}\r\ncf{m<863:xp,R}\r\nbjl{m>1676:xg,s>3264:cf,s<2873:gl,cg}\r\njl{a>2645:R,a<2272:A,R}\r\ngkj{x>3097:lh,m>3723:fxv,R}\r\nhgx{a<2317:zh,bz}\r\ngl{m<669:R,rm}\r\njc{a<940:R,R}\r\nzc{s>3283:vn,s>2491:R,dd}\r\nmk{a>932:A,s>2605:qft,s<2591:rrb,R}\r\nlm{a>3182:A,m>807:R,A}\r\ncrq{s<1950:fpb,vzs}\r\nft{m<228:vs,m>362:txl,qhh}\r\nqmn{x>3417:A,s<724:A,s<1577:R,rmg}\r\nffb{s<3279:rlr,xpf}\r\nzfd{m<612:A,m>1076:R,R}\r\ndtq{m<2745:R,R}\r\nbzr{x>3390:bp,R}\r\nkr{x>3517:cnn,a<1807:ghb,s>2518:cj,ld}\r\ngj{m<1613:kr,cm}\r\nmt{x<3132:R,dnh}\r\nnvs{m>1916:A,A}\r\nqrt{x>3293:R,m>244:R,a<2764:R,R}\r\ntjh{s<3024:R,s<3504:kcz,a>2172:tc,fvz}\r\nxcv{s<853:mck,x>2933:bvq,a>1527:ngt,sz}\r\nlgs{m<3122:R,R}\r\nzg{s<3119:jr,zcc}\r\nznx{s<821:R,x>407:R,A}\r\nbp{s<1466:R,a<2822:R,m<2517:R,A}\r\ndd{a<2900:A,R}\r\nrbg{s<2594:nc,hh}\r\nkc{x>228:R,R}\r\nnts{x<2171:nl,ds}\r\nsjh{m>262:R,x<3320:kh,A}\r\nfv{x<974:A,a>1329:vd,x>1154:dz,dtq}\r\nnp{m>2901:zxn,s<1894:A,s<2229:A,xn}\r\nmr{s>2671:lfb,s<2379:fb,s>2568:mk,tz}\r\nhfv{a<1246:gls,s<1496:jzz,zg}\r\nzmx{a<3168:ff,A}\r\nvkz{s>2647:A,s>2206:R,R}\r\nfth{x<3911:bjg,pch}\r\njn{m>3853:R,x>3385:R,R}\r\nsd{x>3775:R,s>2449:cz,a<405:A,rnz}\r\nqv{a<1021:R,s<2252:R,R}\r\nffl{m>1027:R,R}\r\nzzs{s>1866:R,m<3209:A,m<3609:A,A}\r\nhsf{s>1476:R,R}\r\nthg{s>3652:R,s<3508:R,x>1068:hr,mzk}\r\nkg{x>2965:lvs,x>2887:A,x<2860:bpf,pqv}\r\nnx{x<2779:A,s>2164:R,m>438:R,R}\r\nmd{m>701:R,s>3344:cth,a>2599:qrt,bcf}\r\nxx{x>1273:qm,tv}\r\ngtv{a>3261:R,A}\r\nnq{s>2860:hp,R}\r\ntz{a>689:jjj,a<372:A,cjf}\r\nsrz{m<331:nqx,a<1166:sd,bx}\r\nnf{a<2077:R,x>3322:A,R}\r\nmh{x<3013:A,m<2292:R,a>2375:R,R}\r\nqzt{s<938:A,x<2719:R,m<1478:R,R}\r\nkb{a>3541:A,A}\r\nlvt{a<2737:R,x>3246:A,R}\r\nqlh{m>2051:vll,R}\r\nvn{a<2909:R,A}\r\nrtm{a<1680:bfv,R}\r\njzh{a<3240:R,x>3271:R,a<3499:A,A}\r\nssg{a>2380:lf,s>370:A,A}\r\nglv{s<1131:A,R}\r\nbkf{a<2591:R,a>2676:R,x<350:R,R}\r\nxhx{x<855:R,m<766:A,A}\r\nbqg{x>3272:A,x>3214:R,a<3112:A,A}\r\nbc{x<156:A,a>934:R,m<2168:R,R}\r\nrl{m>3333:R,a<2865:R,R}\r\ncth{m<397:A,A}\r\nrx{x>1610:A,m>3500:A,a>2000:R,R}\r\ntj{s>979:rp,R}\r\nprm{x>3770:R,R}\r\nfhd{m>1529:R,R}\r\nrdq{m<3743:A,m>3890:R,m>3836:R,A}\r\nsvr{s<1277:A,R}\r\nrxb{a<2065:A,m<619:R,R}\r\njkm{a<2967:A,R}\r\nnpf{x<2238:R,R}\r\nhgj{s>3122:A,a<3097:jkm,x>3627:lv,A}\r\nmx{a>1554:pfn,m<437:pxv,x<3296:R,A}\r\ntfx{x<992:A,x<1093:pq,a>2544:lgr,A}\r\npq{a>2392:A,A}\r\nvcg{s>1038:R,a<499:A,R}\r\nbq{x>3320:xk,kvk}\r\nmzk{s>3568:A,x<853:R,R}\r\nkbk{s<3343:A,R}\r\nlhn{x>2868:R,s<838:R,R}\r\ncql{s<732:R,A}\r\nnvq{x>2634:zht,A}\r\nhqg{a>2554:A,R}\r\nrrb{m>2127:A,x>2881:R,A}\r\ngqt{s<2499:A,s<2623:A,a>3424:R,R}\r\ncsh{a>624:R,s<1599:tt,m>1434:A,R}\r\npnk{m<2982:R,m>3177:A,R}\r\nxg{s<3449:sh,a<1459:R,s>3790:A,hq}\r\ngd{a<763:R,a>1542:A,A}\r\ngtg{s>1721:pnk,s<1544:A,fgr}\r\njcv{s>2830:A,x>3291:R,R}\r\nhrh{m>3490:jlm,mp}\r\nbxn{s>3078:R,A}\r\nxbb{m>3000:R,m<2557:R,a<3329:A,A}\r\njzn{s>2306:R,x<2986:R,a>2949:A,A}\r\ncbz{m<2452:R,m>2653:A,m>2537:R,A}\r\nzbt{x>273:ms,x>109:zmx,hpb}\r\nctj{m<1790:frz,x>2123:mbm,R}\r\npcp{s<3380:A,m>1195:A,x>2990:A,R}\r\njhc{s<2482:jsx,R}\r\ncz{m>653:R,x>3649:A,A}\r\nbfv{s<548:A,a>638:R,a>396:A,A}\r\nspr{a>3678:R,x<1552:A,x>1735:A,A}\r\nvr{a>3020:R,R}\r\nms{m<2429:A,a>3099:R,x>425:nkc,rl}\r\ntnn{a>3093:R,A}\r\nqtq{a>912:R,a>597:R,R}\r\njct{x>3362:R,m>1030:A,m<883:R,R}\r\nbvq{s<1295:dzb,jtp}\r\nlls{x>2726:A,a<2507:R,x<2648:A,R}\r\ntn{x>951:A,nrz}\r\ncr{m<1004:R,x<1025:R,R}\r\nvll{m>2293:A,m>2192:A,A}\r\ndv{m<1039:jm,A}\r\ntt{m>862:A,R}\r\nlcv{s>1479:A,x<3886:zl,s<952:A,rv}\r\ngt{m<1480:R,jfs}\r\ngqv{s>3635:A,A}\r\nkqz{s>3214:A,A}\r\nsx{x>787:A,R}\r\ntg{a>1450:R,x>3694:A,s>1757:R,A}\r\nhvc{x<578:xck,m<2269:hfv,ng}\r\nmg{x<1565:A,A}\r\nlvq{x>3284:R,s>3217:R,A}\r\nkrr{a<3777:kc,x<239:A,A}\r\nhb{x<2694:js,vm}\r\nbx{a<1924:R,ljq}\r\njzz{a<1738:cb,s>901:xhx,a>1962:R,R}\r\nrr{s>896:A,R}\r\nqcg{a<2516:R,R}\r\nkxs{x>840:A,x<747:A,a>1356:A,A}\r\nlfj{s<2038:zb,m<3166:gff,a>3183:xl,cc}\r\ngqd{s>864:R,a<2993:R,a<3181:R,A}\r\ndkd{x>2780:R,m<441:A,A}\r\nbjf{m>1394:R,a>2548:A,A}\r\nch{m>3354:xjg,bmk}\r\nvc{x>267:txp,x>173:gt,jlf}\r\njx{a<256:lgm,R}\r\ngfb{x<3822:A,m>2902:zgd,x<3888:cbz,R}\r\npk{s<1524:R,s<2065:A,a>3212:ffr,R}\r\nsm{m>974:pbr,A}\r\njgl{m<2296:zcl,a>914:zzs,a<482:R,gzd}\r\nnhd{a<3391:A,A}\r\nrm{x<2052:R,A}\r\nhpb{x>65:R,a>3263:cql,s<699:sxj,dkt}\r\nxmg{a>1190:sk,a<652:jx,s>2015:qtr,kp}\r\nfvb{s<2321:R,x>3359:R,R}\r\ngqk{a<2630:R,A}\r\nzvr{s>1828:R,x<3360:bqg,a>2878:vbb,tp}\r\ncc{x>3643:trm,bn}\r\nqj{a>3458:mq,ln}\r\npb{a<2589:A,a>2846:A,m<652:A,A}\r\nkz{x<3313:A,R}\r\nfhq{a<2306:bjl,a<3115:xf,s>3112:ccd,gf}\r\nxdb{x<1943:xbb,s>3562:R,A}\r\nxn{x<892:A,a<3291:A,x>1048:R,A}\r\ndqf{x>3370:A,A}\r\njfs{a>3339:R,a>3124:R,A}\r\nxlf{x<3542:xsq,prm}\r\nhq{s<3606:A,s<3671:A,R}\r\nmn{x<3346:R,R}\r\nhj{a<2854:fz,A}\r\nbjg{s<1680:A,R}\r\nbz{x<2925:A,s<2864:gqt,kbk}\r\nllm{x<2811:qcg,x>2864:R,a>2745:A,R}\r\ndq{x>3350:knc,lvq}\r\ngn{x>3784:R,a<2766:gqk,xxp}\r\nvs{s<2568:jzn,x>2977:A,R}\r\nmnv{m>2422:fk,x<3599:R,a<3471:A,R}\r\nqhh{x<2968:ljg,R}\r\nmsk{a<1922:R,cs}\r\nrnz{m>540:R,R}\r\nxgp{a>1935:R,a>1818:dkd,a<1776:A,A}\r\nqhv{a>998:A,a<593:A,hzm}\r\ngf{x>1860:nts,a<3480:nq,s>2782:jd,zs}\r\nnrz{m>3457:R,R}\r\npt{m>2776:R,A}\r\npbr{a>3065:R,x>3090:A,m>1827:R,R}\r\nzb{x>3484:lgs,a>3470:bv,R}\r\nfpb{a<2199:dn,x>2822:fq,ssd}\r\nbv{s>795:A,s>510:R,A}\r\nvnf{m>1189:A,A}\r\nlv{m<3761:A,A}\r\nhv{x<3464:A,A}\r\nffg{m>2301:bkf,bjf}\r\nsk{s>1830:rhg,m<935:R,m<1717:R,qp}\r\nznr{x>319:dj,m<1775:R,m>2856:xcq,bc}\r\njtp{m<1284:R,R}\r\nbj{x>2041:dt,s>2024:R,m>2936:rx,R}\r\nrv{m>1140:R,s>1291:R,x>3930:A,R}\r\ngkz{m<3746:A,x>2666:A,R}\r\nprv{x>1656:A,x>1447:R,m<1940:A,R}\r\ndnh{s>2788:A,R}\r\nqq{x>72:R,A}\r\nvb{a<2857:rds,x<2718:R,A}\r\ndj{s>419:A,a>928:R,x>421:R,R}\r\nrc{a<1146:jct,R}\r\nbb{a>2075:zc,bzx}\r\njm{m<919:A,R}\r\njj{m<1067:R,a<3369:A,R}\r\nsmb{a>645:R,qzt}\r\nlr{x>3337:thl,x>3276:A,x<3223:vr,lm}\r\nrq{a<3448:rdq,A}\r\nnsx{a>318:fvb,jk}\r\ndqd{m<3010:jzr,x>3543:hrh,s<2149:qmn,cl}\r\nvzs{m<3264:ffb,x<2813:bb,x>3004:jp,hgx}\r\ncg{a<1077:A,m>680:A,s>3091:R,R}\r\nthl{a<2939:R,m>836:R,R}\r\nlfb{s<3163:cxt,zbc}\r\nhk{m>1305:lmt,s<1042:R,x<3332:jzh,vnf}\r\nlmb{s>392:A,x>3497:R,R}\r\nkp{s>1605:cgx,a<869:A,A}\r\nrmg{m>3471:A,a>1987:R,A}\r\ncj{a<3154:xpd,qj}\r\nhjh{s>438:ndp,x<2990:R,R}\r\nlzj{m<3379:rbq,s<1060:R,a<1413:R,R}\r\nxt{x>3666:sq,s>3083:A,m<1802:R,R}\r\nxr{a<2655:sv,s>449:gqd,R}\r\npj{x<1807:R,s<3030:dm,fx}\r\nhp{a>3286:R,x>1486:R,A}\r\nppq{s>374:A,A}\r\nxpd{a<2339:stf,a>2848:ll,md}\r\nbdj{m<1473:R,a<2491:A,x>1144:R,A}\r\nfn{a<3456:A,R}\r\nlmt{a<3104:A,R}\r\nsdc{m<660:R,R}\r\nqb{x>3231:R,A}\r\nds{x<2355:R,A}\r\nhcv{m<452:R,R}\r\ncgx{s<1866:A,x>1983:R,a>849:A,R}\r\nndp{x>2968:A,m<2909:A,A}\r\nnl{s<2686:R,m<1818:A,m<3153:A,A}\r\nrp{a>3751:A,s>1387:A,x>3721:R,A}\r\nrgg{m>944:R,s<1930:vcp,m>413:mg,bpr}\r\njsx{x<2639:R,a<2210:A,m>949:R,R}\r\nffr{a<3563:A,x>3419:A,a>3749:R,A}\r\nnxp{m<571:hsf,m<1063:lsg,m<1247:A,lls}\r\ntmh{m>2732:A,A}\r\ngfc{x>3656:R,s>1835:R,R}\r\njvl{s>3628:A,A}\r\ndgp{a<3391:R,R}\r\n\r\n{x=2646,m=48,a=1018,s=1619}\r\n{x=1480,m=59,a=1760,s=1135}\r\n{x=1941,m=1032,a=142,s=649}\r\n{x=1907,m=2539,a=281,s=336}\r\n{x=213,m=582,a=580,s=17}\r\n{x=155,m=143,a=132,s=1308}\r\n{x=416,m=273,a=23,s=644}\r\n{x=79,m=2684,a=253,s=1159}\r\n{x=497,m=487,a=25,s=137}\r\n{x=164,m=1363,a=231,s=1700}\r\n{x=1048,m=973,a=324,s=644}\r\n{x=13,m=506,a=537,s=53}\r\n{x=91,m=73,a=1971,s=1389}\r\n{x=95,m=779,a=33,s=721}\r\n{x=1271,m=2950,a=400,s=2398}\r\n{x=156,m=238,a=2122,s=879}\r\n{x=1296,m=31,a=33,s=1510}\r\n{x=313,m=1933,a=1784,s=2099}\r\n{x=1084,m=160,a=594,s=874}\r\n{x=1653,m=778,a=1034,s=1402}\r\n{x=1412,m=234,a=125,s=755}\r\n{x=1449,m=306,a=1191,s=267}\r\n{x=588,m=1776,a=103,s=1945}\r\n{x=1595,m=1437,a=2326,s=381}\r\n{x=1856,m=1840,a=71,s=1539}\r\n{x=893,m=141,a=141,s=952}\r\n{x=381,m=152,a=524,s=3098}\r\n{x=353,m=1360,a=255,s=1245}\r\n{x=5,m=701,a=1693,s=18}\r\n{x=582,m=1159,a=531,s=172}\r\n{x=313,m=965,a=1451,s=326}\r\n{x=118,m=554,a=1967,s=2126}\r\n{x=1421,m=1872,a=1181,s=259}\r\n{x=422,m=985,a=2544,s=1024}\r\n{x=209,m=572,a=1937,s=1325}\r\n{x=3126,m=9,a=826,s=1902}\r\n{x=2531,m=686,a=283,s=166}\r\n{x=977,m=817,a=2938,s=474}\r\n{x=2798,m=1645,a=1595,s=295}\r\n{x=2161,m=1035,a=833,s=2412}\r\n{x=78,m=915,a=133,s=723}\r\n{x=219,m=1807,a=1086,s=226}\r\n{x=101,m=1096,a=2766,s=772}\r\n{x=84,m=754,a=66,s=495}\r\n{x=5,m=536,a=534,s=800}\r\n{x=953,m=989,a=1141,s=318}\r\n{x=1398,m=24,a=1746,s=19}\r\n{x=2903,m=2068,a=1702,s=314}\r\n{x=212,m=170,a=726,s=1334}\r\n{x=1149,m=72,a=11,s=2276}\r\n{x=1201,m=244,a=630,s=1717}\r\n{x=86,m=315,a=733,s=1001}\r\n{x=5,m=35,a=167,s=303}\r\n{x=14,m=1493,a=1081,s=465}\r\n{x=1,m=556,a=2714,s=1624}\r\n{x=1,m=128,a=293,s=1632}\r\n{x=406,m=1978,a=178,s=272}\r\n{x=118,m=1671,a=34,s=731}\r\n{x=1853,m=245,a=271,s=52}\r\n{x=2202,m=1229,a=1043,s=1275}\r\n{x=2324,m=1514,a=1298,s=270}\r\n{x=372,m=395,a=1095,s=1383}\r\n{x=1492,m=723,a=1279,s=446}\r\n{x=2181,m=3750,a=1937,s=2951}\r\n{x=82,m=1380,a=3640,s=354}\r\n{x=422,m=3067,a=238,s=101}\r\n{x=2189,m=245,a=2637,s=1146}\r\n{x=444,m=117,a=139,s=498}\r\n{x=1111,m=2172,a=76,s=93}\r\n{x=1040,m=150,a=2152,s=857}\r\n{x=436,m=1393,a=3218,s=156}\r\n{x=1189,m=278,a=2371,s=83}\r\n{x=1236,m=413,a=1814,s=1152}\r\n{x=196,m=160,a=1452,s=587}\r\n{x=1366,m=26,a=35,s=464}\r\n{x=10,m=1110,a=84,s=852}\r\n{x=2216,m=1831,a=2161,s=569}\r\n{x=1439,m=1,a=320,s=1722}\r\n{x=1189,m=226,a=376,s=2111}\r\n{x=1294,m=696,a=1112,s=434}\r\n{x=2055,m=2629,a=1411,s=80}\r\n{x=2498,m=841,a=130,s=1108}\r\n{x=85,m=3212,a=112,s=983}\r\n{x=3543,m=1752,a=455,s=1369}\r\n{x=33,m=3113,a=633,s=32}\r\n{x=176,m=1001,a=2080,s=1935}\r\n{x=1282,m=320,a=167,s=2733}\r\n{x=1940,m=159,a=356,s=27}\r\n{x=705,m=481,a=257,s=1752}\r\n{x=719,m=411,a=1536,s=330}\r\n{x=1045,m=90,a=60,s=266}\r\n{x=148,m=502,a=2549,s=1904}\r\n{x=199,m=43,a=1324,s=17}\r\n{x=3042,m=811,a=2606,s=219}\r\n{x=186,m=412,a=53,s=353}\r\n{x=94,m=1271,a=1950,s=67}\r\n{x=2631,m=1728,a=1573,s=153}\r\n{x=3,m=210,a=1542,s=1650}\r\n{x=665,m=1737,a=176,s=219}\r\n{x=398,m=393,a=1587,s=2415}\r\n{x=348,m=1461,a=265,s=1192}\r\n{x=448,m=1036,a=1115,s=107}\r\n{x=881,m=1086,a=939,s=1185}\r\n{x=1,m=737,a=1404,s=142}\r\n{x=661,m=1549,a=1566,s=1258}\r\n{x=526,m=3293,a=597,s=406}\r\n{x=2120,m=1010,a=619,s=3058}\r\n{x=2996,m=352,a=1692,s=852}\r\n{x=196,m=558,a=2470,s=52}\r\n{x=3315,m=258,a=699,s=508}\r\n{x=787,m=732,a=2235,s=34}\r\n{x=332,m=390,a=183,s=583}\r\n{x=743,m=190,a=406,s=139}\r\n{x=2764,m=1636,a=2897,s=105}\r\n{x=41,m=1436,a=1885,s=501}\r\n{x=1958,m=1469,a=2482,s=272}\r\n{x=752,m=1267,a=909,s=2629}\r\n{x=1167,m=108,a=1220,s=1043}\r\n{x=1029,m=154,a=1880,s=653}\r\n{x=1554,m=634,a=522,s=661}\r\n{x=699,m=573,a=1616,s=481}\r\n{x=2340,m=656,a=1597,s=1562}\r\n{x=316,m=2501,a=229,s=1007}\r\n{x=875,m=42,a=3551,s=1825}\r\n{x=1156,m=2038,a=13,s=540}\r\n{x=76,m=900,a=607,s=1092}\r\n{x=2680,m=219,a=1446,s=168}\r\n{x=747,m=422,a=1626,s=1470}\r\n{x=3323,m=666,a=2561,s=1266}\r\n{x=682,m=540,a=554,s=180}\r\n{x=529,m=35,a=120,s=936}\r\n{x=1722,m=1177,a=2177,s=1238}\r\n{x=2533,m=443,a=110,s=674}\r\n{x=106,m=205,a=2205,s=287}\r\n{x=2632,m=158,a=17,s=430}\r\n{x=2225,m=2002,a=813,s=1476}\r\n{x=1025,m=1383,a=2434,s=112}\r\n{x=826,m=1107,a=681,s=787}\r\n{x=708,m=641,a=748,s=1004}\r\n{x=1482,m=1135,a=69,s=266}\r\n{x=596,m=1729,a=207,s=1778}\r\n{x=250,m=827,a=1333,s=1000}\r\n{x=2053,m=274,a=1781,s=138}\r\n{x=68,m=628,a=849,s=140}\r\n{x=1753,m=2469,a=257,s=950}\r\n{x=27,m=112,a=204,s=2145}\r\n{x=654,m=702,a=340,s=2178}\r\n{x=1453,m=1151,a=87,s=862}\r\n{x=126,m=3343,a=44,s=1886}\r\n{x=112,m=1388,a=1101,s=900}\r\n{x=2037,m=1169,a=1554,s=2091}\r\n{x=774,m=649,a=348,s=541}\r\n{x=862,m=1986,a=163,s=814}\r\n{x=85,m=13,a=1279,s=659}\r\n{x=521,m=294,a=517,s=501}\r\n{x=64,m=2828,a=1225,s=1054}\r\n{x=1983,m=254,a=1284,s=2125}\r\n{x=129,m=1296,a=267,s=347}\r\n{x=852,m=925,a=2136,s=1209}\r\n{x=1137,m=71,a=2835,s=379}\r\n{x=202,m=759,a=2932,s=1971}\r\n{x=1398,m=184,a=3218,s=418}\r\n{x=1772,m=230,a=86,s=1026}\r\n{x=1695,m=2056,a=681,s=1483}\r\n{x=127,m=2193,a=3390,s=261}\r\n{x=2411,m=666,a=292,s=215}\r\n{x=941,m=1256,a=971,s=94}\r\n{x=241,m=2596,a=317,s=1970}\r\n{x=75,m=19,a=856,s=629}\r\n{x=1593,m=369,a=195,s=39}\r\n{x=61,m=688,a=546,s=3324}\r\n{x=460,m=2409,a=675,s=59}\r\n{x=2696,m=2425,a=1183,s=3328}\r\n{x=43,m=102,a=896,s=983}\r\n{x=1055,m=445,a=912,s=1090}\r\n{x=1733,m=977,a=170,s=497}\r\n{x=978,m=95,a=594,s=105}\r\n{x=3247,m=147,a=1282,s=119}\r\n{x=2032,m=882,a=74,s=1028}\r\n{x=30,m=2017,a=1965,s=1701}\r\n{x=425,m=162,a=1624,s=77}\r\n{x=513,m=18,a=395,s=148}\r\n{x=2176,m=1267,a=757,s=841}\r\n{x=805,m=1062,a=1008,s=759}\r\n{x=86,m=215,a=30,s=1024}\r\n{x=191,m=2760,a=108,s=320}\r\n{x=853,m=32,a=699,s=868}\r\n{x=2365,m=730,a=1893,s=920}\r\n{x=172,m=62,a=244,s=3137}\r\n{x=2716,m=1192,a=2443,s=3036}\r\n{x=2083,m=358,a=980,s=2170}\r\n{x=1221,m=428,a=410,s=115}\r\n{x=2771,m=350,a=2291,s=2288}\r\n{x=822,m=243,a=68,s=2121}\r\n{x=522,m=203,a=2670,s=10}\r\n{x=5,m=554,a=797,s=345}\r\n{x=2784,m=3282,a=1543,s=685}\r\n{x=811,m=1857,a=708,s=1757}\r\n{x=874,m=64,a=631,s=2416}\r\n{x=472,m=796,a=2160,s=343}";
            string demo1 = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";

            string temp = input;

            string workflowsString = temp.Split("\r\n\r\n")[0];
            string startId = "in";
            long total = 0;


            Dictionary<string, Workflow> workflows = new Dictionary<string, Workflow>();

            string[] workflowArr = workflowsString.Split("\r\n");

            foreach (string workflow in workflowArr)
            {
                string workflowId = workflow.Split('{')[0];
                string workflowChecks = workflow.Split('{')[1].Replace("}", "");

                Workflow newWorkflow = new Workflow();

                string[] checkArr = workflowChecks.Split(",");

                foreach (string check in checkArr)
                {
                    Check newCheck = new Check();

                    if (checkArr.Last() == check)
                    {
                        newCheck.reference = 'x';
                        newCheck.comparer = '>';
                        newCheck.value = -1;
                        newCheck.doNext = check;
                    }
                    else
                    {
                        newCheck.reference = check[0];
                        newCheck.comparer = check[1];
                        newCheck.value = Convert.ToInt32(check.Split(':')[0].Substring(2));
                        newCheck.doNext = check.Split(':')[1];
                    }

                    newWorkflow.checks.Add(newCheck);
                }

                workflows.Add(workflowId, newWorkflow);
            }


            string partRatings = temp.Split("\r\n\r\n")[1];
            string[] partRatingArr = partRatings.Split("\r\n");
            Dictionary<char, int> partRatingDic = new Dictionary<char, int>();
            partRatingDic.Add('x', 0);
            partRatingDic.Add('m', 0);
            partRatingDic.Add('a', 0);
            partRatingDic.Add('s', 0);
            bool checkOutcome = false;

            foreach (string partRating in partRatingArr)
            {
                string moveTo = startId;
                string[] xmasValuesArr = partRating.Split(',');
                partRatingDic['x'] = Convert.ToInt32(xmasValuesArr[0].Substring(3));
                partRatingDic['m'] = Convert.ToInt32(xmasValuesArr[1].Substring(2));
                partRatingDic['a'] = Convert.ToInt32(xmasValuesArr[2].Substring(2));
                partRatingDic['s'] = Convert.ToInt32(xmasValuesArr[3].Substring(2).Replace("}", ""));
                do
                {
                    Workflow thisWorkflow = workflows[moveTo];
                    foreach (var check in thisWorkflow.checks)
                    {
                        checkOutcome = false;

                        switch (check.comparer)
                        {
                            case '<':
                                if (partRatingDic[check.reference] < check.value)
                                {
                                    checkOutcome = true;
                                }
                                break;
                            case '>':
                                if (partRatingDic[check.reference] > check.value)
                                {
                                    checkOutcome = true;
                                }
                                break;
                            default:
                                Console.WriteLine("Something went wrong @ compairer switch");
                                break;
                        }
                        if (checkOutcome)
                        {
                            moveTo = check.doNext;
                            break;
                        }

                    }
                    if (moveTo == "R" || moveTo == "A")
                    {
                        if (moveTo == "A")
                        {
                            total += (partRatingDic['x'] + partRatingDic['m'] + partRatingDic['a'] + partRatingDic['s']);
                        }
                        break;
                    }


                } while (true);


            }







            Console.WriteLine(total);
        }
    }
}
