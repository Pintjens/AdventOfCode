using System.Xml;

namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Refactoring
            Console.WriteLine("Setting up ..\n");
            var start = DateTime.Now;

            string input = "LRLRLLRRLLRRLRRLRRRLLRLRLRLRLRRLRRRLRLRRLRLLRRLLRLRRLRLRRLLRRRLRLRLRRRLRLLRRRLLLLLLRRRLRRLLLRRLRLRRLRRLRLRRLRRLLRRLRRRLRRRLLRLRLLLRRLLLRRLLRRLRLLRRRLRRRLRRRLRLRRLRRLLLRRRLRRLLRRLRRRLRLRLRRLRRLRRRLRRRLRLLLLRRRLRLRRRLRRRLLRLRRLRRLLRLLLRRLRLRRLRRRLRRRLRRRLLRRRLRLLRRRLRRRLRRRLRRRLRRLRRRLLRRLLRLRLRRRLRRRLRLRRRR\r\n\r\nLFM = (PCJ, GQH)\r\nTHP = (SPP, MKB)\r\nPBL = (VVX, JMM)\r\nDSR = (BST, MPD)\r\nQKF = (DSR, KGX)\r\nAAA = (SLH, CVN)\r\nDSH = (DVN, VXT)\r\nVTK = (NSF, QJM)\r\nQQR = (FNB, CBM)\r\nRQV = (XQQ, NQQ)\r\nCGV = (CCB, FTX)\r\nRXL = (HXQ, HLQ)\r\nMQP = (MSH, TJB)\r\nMPL = (JSJ, TJR)\r\nXQK = (RQT, JKB)\r\nGXT = (JFP, MTT)\r\nLHK = (BVR, MFH)\r\nBXH = (PGR, NDC)\r\nFFV = (MJC, TLD)\r\nTFM = (DKJ, RTC)\r\nMVG = (TNC, PXR)\r\nQXN = (CGV, KKM)\r\nLTN = (MQC, XGD)\r\nNLP = (SQQ, DKG)\r\nQTK = (MBH, GJX)\r\nSSR = (DHV, NHN)\r\nDGJ = (QSX, CKB)\r\nSFD = (GRS, DLD)\r\nHBT = (NVN, HJF)\r\nVKH = (CBT, CBT)\r\nVRH = (FVN, JNB)\r\nHTJ = (JNB, FVN)\r\nBDL = (SQS, QVX)\r\nMMC = (MJC, TLD)\r\nRBL = (VNF, BXD)\r\nRNM = (HJQ, PJF)\r\nCTZ = (NCP, PLT)\r\nJFK = (TPJ, JGX)\r\nHPJ = (MMC, FFV)\r\nRJC = (RBH, DFJ)\r\nDHL = (RJC, JFD)\r\nLVR = (BBB, LHK)\r\nLFD = (GCQ, SGC)\r\nBVG = (BSQ, QXH)\r\nDVN = (MTL, NDG)\r\nXGD = (TML, JQL)\r\nRQS = (VXX, BDV)\r\nCPC = (PGB, SVP)\r\nQLQ = (CLK, CBH)\r\nRXZ = (SHG, MDS)\r\nNTR = (RGP, PNX)\r\nBBB = (MFH, BVR)\r\nRGK = (FRD, FRD)\r\nJLV = (DVV, GSF)\r\nNLS = (VFF, HCX)\r\nRHC = (DKG, SQQ)\r\nNVB = (TTG, QTK)\r\nSLZ = (DJM, BVG)\r\nBFK = (SKJ, BBD)\r\nHXX = (XQK, BVT)\r\nSKS = (SLL, FQH)\r\nSGB = (RLT, RHK)\r\nNPD = (RFJ, DJN)\r\nXSJ = (TSF, MVT)\r\nLLH = (RPV, VML)\r\nNXD = (DJS, FJG)\r\nGJX = (SGS, LBJ)\r\nFBV = (CXG, DCJ)\r\nFRX = (GDV, RQB)\r\nSDC = (RGC, THM)\r\nJCT = (CSC, GNM)\r\nSPS = (MLP, TRQ)\r\nBNG = (PFC, CLX)\r\nSHH = (LPM, VRC)\r\nSGC = (FCH, JLC)\r\nFJB = (MVK, JKT)\r\nDRN = (KGL, LTN)\r\nRJB = (NTR, BDN)\r\nDMC = (JBM, KNV)\r\nHBG = (RQB, GDV)\r\nVRC = (RDD, MRD)\r\nJJP = (GQC, VMP)\r\nPLB = (VKX, BGL)\r\nDVV = (QTS, NHG)\r\nLGL = (SSX, JRQ)\r\nRGC = (DVG, RDQ)\r\nGPK = (DDL, FLG)\r\nNVN = (HPJ, SFK)\r\nDVQ = (JFJ, FRC)\r\nVDP = (PFL, GLN)\r\nCVN = (HNX, QKF)\r\nQXP = (VTG, BDC)\r\nLKT = (SBP, SBP)\r\nQSX = (FNN, FKT)\r\nCSC = (HPQ, SLS)\r\nFNN = (DCV, JKF)\r\nMTH = (NVN, HJF)\r\nTPJ = (HNM, NGV)\r\nNHN = (VCC, RXL)\r\nBHF = (JKK, LFD)\r\nHXQ = (VNH, FBV)\r\nKDR = (HDN, HJJ)\r\nSVD = (VRK, STT)\r\nFGJ = (TNM, CRD)\r\nXFF = (NPD, RXQ)\r\nTNC = (XKT, LRP)\r\nVBM = (GJM, PBK)\r\nXBV = (DGJ, QJN)\r\nGXH = (LVK, QGX)\r\nSLH = (HNX, QKF)\r\nZZZ = (CVN, SLH)\r\nRTC = (TPH, FJT)\r\nNQP = (MJH, MSP)\r\nXSD = (STT, VRK)\r\nHJJ = (XMV, TJX)\r\nJFP = (XSV, KBQ)\r\nFTD = (NMN, PXX)\r\nNVQ = (MSP, MJH)\r\nSHC = (PTV, XDR)\r\nDCV = (TFX, TFX)\r\nBTX = (JJG, FLL)\r\nRDQ = (DCF, FRH)\r\nMTT = (KBQ, XSV)\r\nDRB = (RML, LGR)\r\nPBD = (VSX, FRS)\r\nHFS = (KBM, KSJ)\r\nSKJ = (NXN, LJM)\r\nMTS = (GJC, SQX)\r\nBRL = (TMJ, JTT)\r\nTTQ = (KFC, DPL)\r\nLQF = (DJS, FJG)\r\nTKG = (JFD, RJC)\r\nPGB = (BFJ, BQJ)\r\nBQX = (VHC, PQH)\r\nMRD = (BTB, NJK)\r\nLJF = (XQR, PMH)\r\nBCL = (VBK, JHN)\r\nBHQ = (VMB, SQF)\r\nBSR = (LPM, VRC)\r\nVNK = (GBH, LPQ)\r\nKHJ = (NJG, QQL)\r\nVMB = (BBK, VXF)\r\nQJM = (QDN, VFV)\r\nKFC = (FSM, PMF)\r\nJVN = (DMJ, SPR)\r\nMVT = (RGM, HDH)\r\nPQB = (BVP, NTH)\r\nQQF = (KJP, BDP)\r\nRGP = (JJP, MFM)\r\nDLD = (VSG, BDL)\r\nSCV = (CBT, LHV)\r\nVTD = (KLC, QVL)\r\nFCH = (GGR, TFM)\r\nGJR = (QMX, CFM)\r\nPMH = (GSG, JSF)\r\nDCJ = (CDJ, TRP)\r\nQJX = (NVQ, NQP)\r\nDJN = (JFK, HFM)\r\nDQP = (DSS, PBL)\r\nXXH = (NTX, QLG)\r\nMXK = (JTT, TMJ)\r\nFDL = (JCT, TRR)\r\nMGA = (PLT, NCP)\r\nHPS = (RFQ, VXV)\r\nSBC = (NPD, RXQ)\r\nXPD = (VHH, PDH)\r\nSRX = (SSX, JRQ)\r\nCKJ = (MQQ, QJX)\r\nFKT = (DCV, JKF)\r\nJKP = (VFF, HCX)\r\nJMN = (XSJ, CQP)\r\nGLN = (SFQ, SGB)\r\nPTV = (JNS, FXR)\r\nFXM = (NTR, BDN)\r\nDJS = (XMQ, KSN)\r\nLVC = (FRD, PNN)\r\nJPD = (PQP, XCX)\r\nGQC = (NSQ, GJD)\r\nSFK = (FFV, MMC)\r\nJBD = (TFG, MSN)\r\nBSZ = (RGR, FTD)\r\nSQX = (XRQ, PQB)\r\nPPV = (VBD, SNX)\r\nJSF = (FRT, MVG)\r\nJMT = (TJG, BNV)\r\nJMJ = (DCX, BNG)\r\nKJP = (QFH, VSP)\r\nVXV = (SHM, NMD)\r\nKLC = (XLB, MCH)\r\nJMD = (XQQ, NQQ)\r\nPJN = (FDL, BQC)\r\nPLT = (MCP, VHB)\r\nBGL = (DSC, PSN)\r\nRXH = (SLH, CVN)\r\nVSG = (QVX, SQS)\r\nBDC = (RPS, RBL)\r\nJMM = (XMJ, XDG)\r\nRHK = (QKH, BTX)\r\nRQX = (KSM, PLB)\r\nFQH = (MHT, CDG)\r\nSRM = (PLV, QGV)\r\nHNX = (DSR, KGX)\r\nJNS = (RJN, RXD)\r\nMLP = (JMN, PCR)\r\nLVK = (JHS, QMJ)\r\nPRG = (TJB, MSH)\r\nVGS = (JXR, JLP)\r\nXQQ = (KTJ, BMN)\r\nDGA = (FTD, RGR)\r\nHTX = (MTG, XBV)\r\nCCB = (TXB, VTK)\r\nRQT = (TLR, LDB)\r\nQMX = (SHQ, DPB)\r\nMDS = (KQD, DMC)\r\nJDC = (LCL, SSR)\r\nNHG = (JMD, RQV)\r\nCBM = (DBH, BHQ)\r\nRKB = (VGP, LLP)\r\nSJD = (PLB, KSM)\r\nCDG = (FBC, TJF)\r\nQGV = (TLB, QVB)\r\nBDS = (SPS, BGH)\r\nDGF = (VKH, VKH)\r\nRLV = (MKB, SPP)\r\nSHG = (KQD, DMC)\r\nKQD = (KNV, JBM)\r\nRMV = (DVV, GSF)\r\nMSH = (XXH, TVV)\r\nFJX = (BVG, DJM)\r\nKCV = (PLV, QGV)\r\nMFH = (HCQ, CNF)\r\nTLD = (MCK, KXR)\r\nSLB = (VGP, LLP)\r\nKSN = (HFF, PPV)\r\nRGV = (BDP, KJP)\r\nCNF = (NBF, PCM)\r\nTJF = (GQB, JNP)\r\nNDG = (MTS, JLF)\r\nVHH = (FXM, RJB)\r\nMPH = (CLK, CBH)\r\nRPM = (NXD, LQF)\r\nJHS = (PGH, MXS)\r\nTRJ = (PJF, HJQ)\r\nRJK = (SSR, LCL)\r\nDPB = (SLB, RKB)\r\nXXD = (FFJ, BBX)\r\nQBX = (CRF, VBM)\r\nRMX = (NGM, CPL)\r\nVXT = (MTL, NDG)\r\nKQN = (QQF, RGV)\r\nSFQ = (RLT, RHK)\r\nQGJ = (XDR, PTV)\r\nMSN = (RMV, JLV)\r\nHCQ = (PCM, NBF)\r\nGKF = (PLT, NCP)\r\nVCC = (HLQ, HXQ)\r\nMSJ = (JKP, NLS)\r\nRFF = (BXM, SPH)\r\nFBD = (DGF, VNG)\r\nGLJ = (MQF, RRT)\r\nQRN = (MTH, HBT)\r\nQGS = (TNM, CRD)\r\nXPP = (FNB, CBM)\r\nQQQ = (GHK, DVD)\r\nRBK = (PPQ, XTT)\r\nHHG = (DPL, KFC)\r\nSBP = (FTD, RGR)\r\nMJH = (MLQ, QTG)\r\nJLX = (BDS, TMM)\r\nDVG = (FRH, DCF)\r\nDFJ = (NSK, PDS)\r\nRHJ = (DKM, TDJ)\r\nFQN = (JKT, MVK)\r\nRMD = (LGR, RML)\r\nJTB = (VDP, BSL)\r\nGJM = (NLD, RHJ)\r\nLGP = (CPC, NQN)\r\nJHN = (NBQ, MSJ)\r\nSQF = (BBK, VXF)\r\nHST = (CFM, QMX)\r\nLBJ = (TBP, VNK)\r\nSNX = (PCX, RMX)\r\nPJF = (MGX, SKS)\r\nRRT = (JTB, LSC)\r\nJTT = (MLM, GLJ)\r\nDLQ = (JBQ, RND)\r\nLGR = (QRV, XXD)\r\nLPT = (BSR, SHH)\r\nHQB = (BRL, MXK)\r\nTRP = (LFM, LCT)\r\nJKT = (RNM, TRJ)\r\nMXS = (GQR, KQN)\r\nMKB = (LVQ, NNX)\r\nNDC = (RGK, LVC)\r\nLFN = (RRL, XNF)\r\nSHQ = (RKB, SLB)\r\nJGX = (NGV, HNM)\r\nRPN = (BCL, CDR)\r\nJSJ = (CRH, FHR)\r\nFRH = (THR, TSX)\r\nBNV = (RXS, LGP)\r\nFLL = (GSR, PVF)\r\nDNS = (JLP, JXR)\r\nHDN = (TJX, XMV)\r\nHJQ = (SKS, MGX)\r\nTNX = (SJD, RQX)\r\nXQD = (BFR, MDM)\r\nGNM = (HPQ, SLS)\r\nNML = (DGF, VNG)\r\nBXM = (FJB, FQN)\r\nMSP = (QTG, MLQ)\r\nPBJ = (XLJ, TKD)\r\nMNN = (DNS, VGS)\r\nRBH = (PDS, NSK)\r\nBFJ = (KNT, SDP)\r\nCRD = (PBC, BFK)\r\nTJB = (XXH, TVV)\r\nPDJ = (SRN, SRN)\r\nXJS = (HBG, FRX)\r\nBBK = (LLH, PNP)\r\nQQL = (MFR, KKZ)\r\nFVN = (LGL, SRX)\r\nLRP = (GXT, BSF)\r\nSVX = (MSN, TFG)\r\nPFC = (PCP, FGB)\r\nXMJ = (GKF, GKF)\r\nLLL = (DNS, VGS)\r\nVSX = (TKG, DHL)\r\nRND = (SBC, XFF)\r\nMLQ = (DXT, JMT)\r\nXLC = (TTG, QTK)\r\nTJG = (RXS, LGP)\r\nDPL = (PMF, FSM)\r\nPCR = (CQP, XSJ)\r\nBSQ = (XSD, SVD)\r\nDHP = (HPS, MNQ)\r\nSCB = (HXX, NQV)\r\nFFJ = (LJF, BSV)\r\nFTX = (VTK, TXB)\r\nTRQ = (PCR, JMN)\r\nGDL = (PBD, BJK)\r\nMLM = (RRT, MQF)\r\nTLA = (QXP, MKM)\r\nSMN = (LFN, FVJ)\r\nRRL = (CKJ, JNK)\r\nBDP = (VSP, QFH)\r\nCBC = (DVN, VXT)\r\nJLP = (PTL, SJK)\r\nFRS = (TKG, DHL)\r\nSQQ = (MPL, QBQ)\r\nDVD = (RLK, JPD)\r\nPQP = (LGN, SFD)\r\nFSM = (JDC, RJK)\r\nPSN = (XJS, NRN)\r\nQDN = (SHC, QGJ)\r\nRJN = (XPD, GMS)\r\nHRT = (PPQ, XTT)\r\nCBH = (SRM, KCV)\r\nFSC = (XBV, MTG)\r\nDCX = (CLX, PFC)\r\nXQR = (GSG, JSF)\r\nHBP = (XDT, KNF)\r\nBQJ = (KNT, SDP)\r\nCDJ = (LFM, LCT)\r\nJNK = (MQQ, QJX)\r\nBVP = (MTF, SDC)\r\nTLR = (RHC, NLP)\r\nSJK = (DQP, LMN)\r\nNJG = (MFR, MFR)\r\nRLK = (XCX, PQP)\r\nTPH = (BXH, GSQ)\r\nNSK = (DDS, MLV)\r\nHLQ = (FBV, VNH)\r\nJTP = (FSN, QQQ)\r\nPGH = (KQN, GQR)\r\nSRJ = (PXK, GDL)\r\nTJR = (FHR, CRH)\r\nXDT = (BKJ, PPJ)\r\nGQH = (RLV, THP)\r\nGRS = (BDL, VSG)\r\nDLJ = (CRF, VBM)\r\nVMP = (GJD, NSQ)\r\nMKM = (VTG, BDC)\r\nPVF = (VLX, LBB)\r\nGPV = (SRJ, FNQ)\r\nNTL = (FSN, QQQ)\r\nFQL = (BFR, MDM)\r\nTMJ = (MLM, GLJ)\r\nXKT = (GXT, BSF)\r\nPCX = (NGM, CPL)\r\nXMV = (HQB, JRJ)\r\nQKH = (FLL, JJG)\r\nVQP = (FLG, DDL)\r\nSLS = (CKK, HVF)\r\nTHM = (RDQ, DVG)\r\nPPJ = (GCT, TNX)\r\nTMM = (BGH, SPS)\r\nGVL = (PCG, RQS)\r\nDCF = (TSX, THR)\r\nBJK = (FRS, VSX)\r\nSPP = (NNX, LVQ)\r\nQGX = (QMJ, JHS)\r\nRPV = (HGR, DHP)\r\nMTG = (DGJ, QJN)\r\nKGL = (XGD, MQC)\r\nDHD = (RND, JBQ)\r\nBXD = (KFH, HTM)\r\nKGX = (MPD, BST)\r\nQVB = (LKT, RGT)\r\nCBK = (RDG, PKT)\r\nBTB = (JMJ, CTD)\r\nFSN = (DVD, GHK)\r\nKXR = (FFT, DVQ)\r\nTML = (GPV, PVN)\r\nVXF = (PNP, LLH)\r\nDBH = (SQF, VMB)\r\nFCP = (JKK, LFD)\r\nRXQ = (DJN, RFJ)\r\nNTH = (SDC, MTF)\r\nJBM = (SVX, JBD)\r\nPNN = (FJX, SLZ)\r\nGQR = (QQF, RGV)\r\nPXR = (LRP, XKT)\r\nVRK = (RDJ, SMN)\r\nLDB = (RHC, NLP)\r\nLHV = (RXH, ZZZ)\r\nFNB = (DBH, BHQ)\r\nMFM = (VMP, GQC)\r\nPGV = (PKT, RDG)\r\nSPR = (XJP, SHD)\r\nCCR = (LQF, NXD)\r\nGJC = (XRQ, PQB)\r\nLGN = (GRS, DLD)\r\nRDG = (FBD, NML)\r\nMCP = (DLC, TGK)\r\nNMD = (XFR, GRK)\r\nMVK = (TRJ, RNM)\r\nJKF = (TFX, KHJ)\r\nXFR = (SMG, JNQ)\r\nNGM = (XPX, JLX)\r\nMFD = (GVL, MBR)\r\nRNT = (CDR, BCL)\r\nVVX = (XMJ, XMJ)\r\nGNC = (HST, GJR)\r\nCRF = (PBK, GJM)\r\nJKK = (GCQ, SGC)\r\nGBH = (QDR, RFF)\r\nFJG = (XMQ, KSN)\r\nGDV = (GQN, GXH)\r\nXLB = (FMN, JVN)\r\nKNV = (JBD, SVX)\r\nPXX = (HHG, TTQ)\r\nTDJ = (MFD, QJT)\r\nQLG = (PJN, VFS)\r\nNRN = (HBG, FRX)\r\nSHM = (GRK, XFR)\r\nFHV = (HXX, NQV)\r\nQFH = (GNC, CHX)\r\nPCM = (QLQ, MPH)\r\nVLX = (QMR, PBJ)\r\nRPP = (HRT, RBK)\r\nJXR = (SJK, PTL)\r\nLPQ = (QDR, RFF)\r\nBFR = (STC, PJT)\r\nXTT = (CBC, DSH)\r\nHVF = (VTD, KDC)\r\nJFJ = (FCP, BHF)\r\nLVQ = (PRG, MQP)\r\nJFD = (RBH, DFJ)\r\nHFM = (TPJ, JGX)\r\nBSV = (XQR, PMH)\r\nJLC = (GGR, TFM)\r\nNSQ = (FHV, SCB)\r\nNCP = (VHB, MCP)\r\nJKB = (LDB, TLR)\r\nBLX = (PDJ, GBX)\r\nSVP = (BQJ, BFJ)\r\nVSP = (CHX, GNC)\r\nSPH = (FJB, FQN)\r\nRPS = (VNF, BXD)\r\nQMR = (TKD, XLJ)\r\nQMJ = (MXS, PGH)\r\nJNB = (LGL, SRX)\r\nRGM = (JTP, NTL)\r\nGHK = (JPD, RLK)\r\nTFX = (NJG, NJG)\r\nNBQ = (JKP, NLS)\r\nNTX = (VFS, PJN)\r\nQTS = (RQV, JMD)\r\nLMN = (DSS, PBL)\r\nCLK = (SRM, KCV)\r\nMPD = (RMD, DRB)\r\nPDS = (DDS, MLV)\r\nNNX = (PRG, MQP)\r\nBST = (DRB, RMD)\r\nDSG = (SGV, DVB)\r\nKDC = (QVL, KLC)\r\nVKX = (PSN, DSC)\r\nLJM = (DBB, QXN)\r\nVFV = (SHC, QGJ)\r\nFXR = (RJN, RXD)\r\nHGR = (HPS, MNQ)\r\nBMN = (CCR, RPM)\r\nCRH = (FSC, HTX)\r\nQRV = (BBX, FFJ)\r\nCKK = (VTD, KDC)\r\nSDP = (RNT, RPN)\r\nXLJ = (JTX, QRN)\r\nBSL = (PFL, GLN)\r\nGJD = (FHV, SCB)\r\nVNH = (DCJ, CXG)\r\nBCB = (MXJ, LVR)\r\nNBF = (MPH, QLQ)\r\nMCK = (DVQ, FFT)\r\nRFJ = (HFM, JFK)\r\nBBD = (LJM, NXN)\r\nFMN = (SPR, DMJ)\r\nJXK = (GPK, VQP)\r\nSLL = (MHT, CDG)\r\nTRR = (GNM, CSC)\r\nMJC = (KXR, MCK)\r\nMHT = (FBC, TJF)\r\nTSF = (HDH, RGM)\r\nFLG = (FQL, XQD)\r\nMGX = (SLL, FQH)\r\nRGR = (NMN, PXX)\r\nRDA = (BVG, DJM)\r\nVXX = (DHD, DLQ)\r\nDXT = (BNV, TJG)\r\nLCL = (DHV, NHN)\r\nCKB = (FNN, FKT)\r\nKNH = (LVR, MXJ)\r\nGSQ = (PGR, NDC)\r\nCFM = (DPB, SHQ)\r\nHDH = (JTP, NTL)\r\nNSF = (VFV, QDN)\r\nHSF = (KSJ, KBM)\r\nGSR = (VLX, LBB)\r\nGCT = (RQX, SJD)\r\nRBN = (XDT, KNF)\r\nXNF = (JNK, CKJ)\r\nTCF = (RBK, HRT)\r\nDPA = (MDS, SHG)\r\nQTG = (JMT, DXT)\r\nRGT = (SBP, BSZ)\r\nXCX = (SFD, LGN)\r\nKSJ = (KDR, GKG)\r\nGQN = (QGX, LVK)\r\nMDM = (PJT, STC)\r\nKKZ = (MKM, QXP)\r\nMQC = (JQL, TML)\r\nVFS = (FDL, BQC)\r\nTJX = (JRJ, HQB)\r\nBSF = (MTT, JFP)\r\nVMD = (PQH, VHC)\r\nJTX = (HBT, MTH)\r\nMCH = (FMN, JVN)\r\nVBK = (MSJ, NBQ)\r\nTBP = (GBH, LPQ)\r\nTVX = (VQP, GPK)\r\nNQN = (SVP, PGB)\r\nSMG = (XLC, NVB)\r\nSHD = (BCB, KNH)\r\nJLF = (SQX, GJC)\r\nGSF = (QTS, NHG)\r\nBDN = (PNX, RGP)\r\nGRK = (SMG, JNQ)\r\nPLV = (TLB, TLB)\r\nSQS = (HTJ, VRH)\r\nPDH = (FXM, RJB)\r\nVGP = (LLL, MNN)\r\nJRQ = (TVT, BLX)\r\nCLX = (PCP, FGB)\r\nPMF = (JDC, RJK)\r\nJRJ = (BRL, MXK)\r\nXMQ = (PPV, HFF)\r\nBVT = (RQT, JKB)\r\nFJT = (BXH, GSQ)\r\nFRT = (TNC, PXR)\r\nQVL = (XLB, MCH)\r\nTNM = (BFK, PBC)\r\nXPX = (BDS, TMM)\r\nXCN = (SHH, BSR)\r\nPKT = (FBD, NML)\r\nTLB = (LKT, LKT)\r\nTFG = (RMV, JLV)\r\nSRN = (MDS, SHG)\r\nFRC = (BHF, FCP)\r\nGGR = (RTC, DKJ)\r\nKFH = (JXK, TVX)\r\nJNQ = (XLC, NVB)\r\nMTF = (RGC, THM)\r\nSTT = (RDJ, SMN)\r\nCPL = (XPX, JLX)\r\nFGB = (XPP, QQR)\r\nDLC = (RPP, TCF)\r\nDJM = (QXH, BSQ)\r\nMBH = (SGS, LBJ)\r\nVBD = (RMX, PCX)\r\nCXG = (TRP, CDJ)\r\nNGV = (VMD, BQX)\r\nGQB = (DRN, NXS)\r\nFHR = (HTX, FSC)\r\nDDL = (FQL, XQD)\r\nFBC = (JNP, GQB)\r\nDKJ = (TPH, FJT)\r\nRQB = (GQN, GXH)\r\nLPM = (RDD, MRD)\r\nBKJ = (GCT, TNX)\r\nGMS = (PDH, VHH)\r\nHTM = (JXK, TVX)\r\nPPQ = (CBC, DSH)\r\nMBR = (RQS, PCG)\r\nPJT = (FGJ, QGS)\r\nPQH = (RBN, HBP)\r\nCBT = (RXH, RXH)\r\nCHX = (HST, GJR)\r\nBQC = (JCT, TRR)\r\nNJK = (JMJ, CTD)\r\nQVX = (VRH, HTJ)\r\nKKM = (FTX, CCB)\r\nNXN = (DBB, QXN)\r\nJQL = (GPV, PVN)\r\nMFR = (QXP, MKM)\r\nVML = (HGR, DHP)\r\nPCJ = (THP, RLV)\r\nXRQ = (BVP, NTH)\r\nPXK = (PBD, BJK)\r\nHCX = (HFS, HSF)\r\nQJT = (MBR, GVL)\r\nRLT = (BTX, QKH)\r\nDKG = (QBQ, MPL)\r\nCQP = (TSF, MVT)\r\nHFF = (VBD, SNX)\r\nKNF = (BKJ, PPJ)\r\nFFT = (JFJ, FRC)\r\nDDS = (PGK, DSG)\r\nPFL = (SGB, SFQ)\r\nRXS = (CPC, NQN)\r\nXSV = (XCN, LPT)\r\nMNQ = (VXV, RFQ)\r\nPVN = (SRJ, FNQ)\r\nVNF = (KFH, HTM)\r\nHPQ = (HVF, CKK)\r\nPGK = (DVB, SGV)\r\nVHC = (HBP, RBN)\r\nGBX = (SRN, RXZ)\r\nSGV = (CBK, PGV)\r\nTVV = (QLG, NTX)\r\nKNT = (RPN, RNT)\r\nTXB = (NSF, QJM)\r\nPCP = (XPP, QQR)\r\nPCG = (BDV, VXX)\r\nMQF = (LSC, JTB)\r\nQJN = (CKB, QSX)\r\nQXH = (SVD, XSD)\r\nLCT = (PCJ, GQH)\r\nGKG = (HDN, HJJ)\r\nTKD = (JTX, QRN)\r\nKBQ = (XCN, LPT)\r\nKSM = (VKX, BGL)\r\nMQQ = (NQP, NVQ)\r\nVFF = (HFS, HSF)\r\nSSX = (TVT, TVT)\r\nDSS = (VVX, VVX)\r\nQDR = (SPH, BXM)\r\nPGR = (RGK, RGK)\r\nRML = (QRV, XXD)\r\nXDR = (JNS, FXR)\r\nDVB = (PGV, CBK)\r\nTSX = (QBX, DLJ)\r\nQBQ = (TJR, JSJ)\r\nBBX = (LJF, BSV)\r\nPTL = (DQP, LMN)\r\nPBC = (BBD, SKJ)\r\nVHB = (DLC, TGK)\r\nXJP = (BCB, KNH)\r\nSTC = (QGS, FGJ)\r\nFNQ = (PXK, GDL)\r\nMXJ = (LHK, BBB)\r\nJNP = (NXS, DRN)\r\nSGS = (TBP, VNK)\r\nRFQ = (SHM, NMD)\r\nMLV = (DSG, PGK)\r\nCDR = (VBK, JHN)\r\nCTD = (DCX, BNG)\r\nFRD = (FJX, FJX)\r\nGCQ = (FCH, JLC)\r\nNXS = (KGL, LTN)\r\nJBQ = (SBC, XFF)\r\nNLD = (DKM, TDJ)\r\nVTG = (RBL, RPS)\r\nJJG = (GSR, PVF)\r\nDKM = (QJT, MFD)\r\nRDJ = (LFN, FVJ)\r\nKTJ = (RPM, CCR)\r\nGSG = (FRT, MVG)\r\nMTL = (JLF, MTS)\r\nPNP = (RPV, VML)\r\nTTG = (MBH, GJX)\r\nLSC = (VDP, BSL)\r\nTHR = (DLJ, QBX)\r\nNQV = (BVT, XQK)\r\nLBB = (PBJ, QMR)\r\nNQQ = (KTJ, BMN)\r\nDMJ = (XJP, SHD)\r\nDSC = (XJS, NRN)\r\nRXD = (GMS, XPD)\r\nKBM = (GKG, KDR)\r\nLLP = (LLL, MNN)\r\nHNM = (VMD, BQX)\r\nVNG = (VKH, SCV)\r\nXDG = (GKF, CTZ)\r\nPNX = (MFM, JJP)\r\nPBK = (RHJ, NLD)\r\nBVR = (CNF, HCQ)\r\nDHV = (VCC, RXL)\r\nTGK = (RPP, TCF)\r\nRDD = (NJK, BTB)\r\nNMN = (HHG, TTQ)\r\nHJF = (HPJ, SFK)\r\nBDV = (DLQ, DHD)\r\nTVT = (PDJ, PDJ)\r\nBGH = (TRQ, MLP)\r\nFVJ = (RRL, XNF)\r\nDBB = (KKM, CGV)";
            string demo1 = "RL\r\n\r\nAAA = (BBB, CCC)\r\nBBB = (DDD, EEE)\r\nCCC = (ZZZ, GGG)\r\nDDD = (DDD, DDD)\r\nEEE = (EEE, EEE)\r\nGGG = (GGG, GGG)\r\nZZZ = (ZZZ, ZZZ)";
            string demo2 = "LLR\r\n\r\nAAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)";
            string demo3 = "LR\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22Z)\r\n22Z = (22B, 22B)\r\nXXX = (XXX, XXX)";
            string demo4 = "LRRRL\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22B)\r\n22Z = (22B, 22B)\r\nXXX = (22A, 11Z)";


            string[] temp = input.Split("\r\n\r\n");

            string directions = temp[0];
            string[] network = temp[1].Split("\r\n");
            int st = directions.Length;

            List<Pointer> pointerList = new List<Pointer>();
            List<Pointer> possitions = new List<Pointer>();
            List<string> targets = new List<string>();
            void Setup()
            {
                foreach (string line in network)
                {
                    string[] split = line.Replace(" =", "").Replace("(", "").Replace(",", "").Replace(")", "").Split(' ');

                    Pointer pointer = pointerList.FirstOrDefault(p => p.Id == split[0]);
                    if (pointer is null)
                    {
                        pointer = new Pointer();
                        pointer.Id = split[0];
                        pointerList.Add(pointer);
                    }
                    Pointer tooLeft = pointerList.FirstOrDefault(p => p.Id == split[1]);
                    if (tooLeft is null)
                    {
                        tooLeft = new Pointer();
                        tooLeft.Id = split[1];
                        pointerList.Add(tooLeft);
                    }
                    Pointer tooRight = pointerList.FirstOrDefault(p => p.Id == split[2]);
                    if (tooRight is null)
                    {
                        tooRight = new Pointer();
                        tooRight.Id = split[2];
                        pointerList.Add(tooRight);
                    }

                    pointer.Left = tooLeft;
                    pointer.Right = tooRight;


                    if (pointer.Id.Last() == 'A')
                    {
                        possitions.Add(pointer);
                    }
                    else if (pointer.Id.Last() == 'Z')
                    {
                        targets.Add(pointer.Id);
                    }
                }
            }
            Setup();

            Console.WriteLine(DateTime.Now.Ticks - start.Ticks + " Ticks later:");
            Console.WriteLine("Setup Done.\n-----------------------------\n\nCalculating..");
            // start calculating
            start = DateTime.Now;

            int count = 0;
            int steps = 0;

            Dictionary<string, List<long>[]> targetHits = new Dictionary<string, List<long>[]>();
            foreach (var target in targets)
            {
                targetHits.Add(target, new List<long>[possitions.Count]);
                for (var i = 0; i < possitions.Count; i++)
                {
                    targetHits[target][i] = new List<long>();
                }
            }

            Dictionary<string, int?> frecuencies = new Dictionary<string, int?>();
            foreach (var target in targets)
            {
                frecuencies.Add(target, null);
            }

            int frecuenciesFound = 0;

            int SetFrequency(int stepsPerCount)
            {
                frecuenciesFound++;
                return (count * stepsPerCount) + (steps + 1);
            }

            bool found = false;
            do
            {
                // found = false;

                if (directions[steps] == 'R')
                {
                    for (int i = 0; i < possitions.Count; i++)
                    {
                        possitions[i] = possitions[i].Right;
                        if (possitions[i].LastIsZ)
                        {
                            frecuencies[possitions[i].Id] ??= SetFrequency(directions.Count());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < possitions.Count; i++)
                    {
                        possitions[i] = possitions[i].Right;
                        if (possitions[i].LastIsZ)
                        {
                            frecuencies[possitions[i].Id] ??= SetFrequency(directions.Count());
                        }
                    }
                }


                //if (possinions[0].Id.Last() == 'Z')
                if (false)
                {

                    found = true;


                    foreach (Pointer possition in possitions)
                    {
                        if (possition.Id.Last() != 'Z')
                        {
                            found = false;
                            break;
                        }
                    }
                }

                steps++;
                if (steps == directions.Length)
                {
                    count++;
                    steps = 0;
                }

            } while (!found && frecuenciesFound < targets.Count);



            Console.WriteLine(DateTime.Now.Ticks - start.Ticks);

            long result = 1;
            foreach (int frequency in frecuencies.Values)
            {
                result *= frequency;
            }

            Console.WriteLine(result *= 307);

            if (result == 12357789728873)
            { // 12357789728873 is right
                Console.WriteLine("Correct");
            }
            else { Console.WriteLine("Not correct"); }


        }
        public void Part2Try2()
        {
            Console.WriteLine("Start");
            string input = "LRLRLLRRLLRRLRRLRRRLLRLRLRLRLRRLRRRLRLRRLRLLRRLLRLRRLRLRRLLRRRLRLRLRRRLRLLRRRLLLLLLRRRLRRLLLRRLRLRRLRRLRLRRLRRLLRRLRRRLRRRLLRLRLLLRRLLLRRLLRRLRLLRRRLRRRLRRRLRLRRLRRLLLRRRLRRLLRRLRRRLRLRLRRLRRLRRRLRRRLRLLLLRRRLRLRRRLRRRLLRLRRLRRLLRLLLRRLRLRRLRRRLRRRLRRRLLRRRLRLLRRRLRRRLRRRLRRRLRRLRRRLLRRLLRLRLRRRLRRRLRLRRRR\r\n\r\nLFM = (PCJ, GQH)\r\nTHP = (SPP, MKB)\r\nPBL = (VVX, JMM)\r\nDSR = (BST, MPD)\r\nQKF = (DSR, KGX)\r\nAAA = (SLH, CVN)\r\nDSH = (DVN, VXT)\r\nVTK = (NSF, QJM)\r\nQQR = (FNB, CBM)\r\nRQV = (XQQ, NQQ)\r\nCGV = (CCB, FTX)\r\nRXL = (HXQ, HLQ)\r\nMQP = (MSH, TJB)\r\nMPL = (JSJ, TJR)\r\nXQK = (RQT, JKB)\r\nGXT = (JFP, MTT)\r\nLHK = (BVR, MFH)\r\nBXH = (PGR, NDC)\r\nFFV = (MJC, TLD)\r\nTFM = (DKJ, RTC)\r\nMVG = (TNC, PXR)\r\nQXN = (CGV, KKM)\r\nLTN = (MQC, XGD)\r\nNLP = (SQQ, DKG)\r\nQTK = (MBH, GJX)\r\nSSR = (DHV, NHN)\r\nDGJ = (QSX, CKB)\r\nSFD = (GRS, DLD)\r\nHBT = (NVN, HJF)\r\nVKH = (CBT, CBT)\r\nVRH = (FVN, JNB)\r\nHTJ = (JNB, FVN)\r\nBDL = (SQS, QVX)\r\nMMC = (MJC, TLD)\r\nRBL = (VNF, BXD)\r\nRNM = (HJQ, PJF)\r\nCTZ = (NCP, PLT)\r\nJFK = (TPJ, JGX)\r\nHPJ = (MMC, FFV)\r\nRJC = (RBH, DFJ)\r\nDHL = (RJC, JFD)\r\nLVR = (BBB, LHK)\r\nLFD = (GCQ, SGC)\r\nBVG = (BSQ, QXH)\r\nDVN = (MTL, NDG)\r\nXGD = (TML, JQL)\r\nRQS = (VXX, BDV)\r\nCPC = (PGB, SVP)\r\nQLQ = (CLK, CBH)\r\nRXZ = (SHG, MDS)\r\nNTR = (RGP, PNX)\r\nBBB = (MFH, BVR)\r\nRGK = (FRD, FRD)\r\nJLV = (DVV, GSF)\r\nNLS = (VFF, HCX)\r\nRHC = (DKG, SQQ)\r\nNVB = (TTG, QTK)\r\nSLZ = (DJM, BVG)\r\nBFK = (SKJ, BBD)\r\nHXX = (XQK, BVT)\r\nSKS = (SLL, FQH)\r\nSGB = (RLT, RHK)\r\nNPD = (RFJ, DJN)\r\nXSJ = (TSF, MVT)\r\nLLH = (RPV, VML)\r\nNXD = (DJS, FJG)\r\nGJX = (SGS, LBJ)\r\nFBV = (CXG, DCJ)\r\nFRX = (GDV, RQB)\r\nSDC = (RGC, THM)\r\nJCT = (CSC, GNM)\r\nSPS = (MLP, TRQ)\r\nBNG = (PFC, CLX)\r\nSHH = (LPM, VRC)\r\nSGC = (FCH, JLC)\r\nFJB = (MVK, JKT)\r\nDRN = (KGL, LTN)\r\nRJB = (NTR, BDN)\r\nDMC = (JBM, KNV)\r\nHBG = (RQB, GDV)\r\nVRC = (RDD, MRD)\r\nJJP = (GQC, VMP)\r\nPLB = (VKX, BGL)\r\nDVV = (QTS, NHG)\r\nLGL = (SSX, JRQ)\r\nRGC = (DVG, RDQ)\r\nGPK = (DDL, FLG)\r\nNVN = (HPJ, SFK)\r\nDVQ = (JFJ, FRC)\r\nVDP = (PFL, GLN)\r\nCVN = (HNX, QKF)\r\nQXP = (VTG, BDC)\r\nLKT = (SBP, SBP)\r\nQSX = (FNN, FKT)\r\nCSC = (HPQ, SLS)\r\nFNN = (DCV, JKF)\r\nMTH = (NVN, HJF)\r\nTPJ = (HNM, NGV)\r\nNHN = (VCC, RXL)\r\nBHF = (JKK, LFD)\r\nHXQ = (VNH, FBV)\r\nKDR = (HDN, HJJ)\r\nSVD = (VRK, STT)\r\nFGJ = (TNM, CRD)\r\nXFF = (NPD, RXQ)\r\nTNC = (XKT, LRP)\r\nVBM = (GJM, PBK)\r\nXBV = (DGJ, QJN)\r\nGXH = (LVK, QGX)\r\nSLH = (HNX, QKF)\r\nZZZ = (CVN, SLH)\r\nRTC = (TPH, FJT)\r\nNQP = (MJH, MSP)\r\nXSD = (STT, VRK)\r\nHJJ = (XMV, TJX)\r\nJFP = (XSV, KBQ)\r\nFTD = (NMN, PXX)\r\nNVQ = (MSP, MJH)\r\nSHC = (PTV, XDR)\r\nDCV = (TFX, TFX)\r\nBTX = (JJG, FLL)\r\nRDQ = (DCF, FRH)\r\nMTT = (KBQ, XSV)\r\nDRB = (RML, LGR)\r\nPBD = (VSX, FRS)\r\nHFS = (KBM, KSJ)\r\nSKJ = (NXN, LJM)\r\nMTS = (GJC, SQX)\r\nBRL = (TMJ, JTT)\r\nTTQ = (KFC, DPL)\r\nLQF = (DJS, FJG)\r\nTKG = (JFD, RJC)\r\nPGB = (BFJ, BQJ)\r\nBQX = (VHC, PQH)\r\nMRD = (BTB, NJK)\r\nLJF = (XQR, PMH)\r\nBCL = (VBK, JHN)\r\nBHQ = (VMB, SQF)\r\nBSR = (LPM, VRC)\r\nVNK = (GBH, LPQ)\r\nKHJ = (NJG, QQL)\r\nVMB = (BBK, VXF)\r\nQJM = (QDN, VFV)\r\nKFC = (FSM, PMF)\r\nJVN = (DMJ, SPR)\r\nMVT = (RGM, HDH)\r\nPQB = (BVP, NTH)\r\nQQF = (KJP, BDP)\r\nRGP = (JJP, MFM)\r\nDLD = (VSG, BDL)\r\nSCV = (CBT, LHV)\r\nVTD = (KLC, QVL)\r\nFCH = (GGR, TFM)\r\nGJR = (QMX, CFM)\r\nPMH = (GSG, JSF)\r\nDCJ = (CDJ, TRP)\r\nQJX = (NVQ, NQP)\r\nDJN = (JFK, HFM)\r\nDQP = (DSS, PBL)\r\nXXH = (NTX, QLG)\r\nMXK = (JTT, TMJ)\r\nFDL = (JCT, TRR)\r\nMGA = (PLT, NCP)\r\nHPS = (RFQ, VXV)\r\nSBC = (NPD, RXQ)\r\nXPD = (VHH, PDH)\r\nSRX = (SSX, JRQ)\r\nCKJ = (MQQ, QJX)\r\nFKT = (DCV, JKF)\r\nJKP = (VFF, HCX)\r\nJMN = (XSJ, CQP)\r\nGLN = (SFQ, SGB)\r\nPTV = (JNS, FXR)\r\nFXM = (NTR, BDN)\r\nDJS = (XMQ, KSN)\r\nLVC = (FRD, PNN)\r\nJPD = (PQP, XCX)\r\nGQC = (NSQ, GJD)\r\nSFK = (FFV, MMC)\r\nJBD = (TFG, MSN)\r\nBSZ = (RGR, FTD)\r\nSQX = (XRQ, PQB)\r\nPPV = (VBD, SNX)\r\nJSF = (FRT, MVG)\r\nJMT = (TJG, BNV)\r\nJMJ = (DCX, BNG)\r\nKJP = (QFH, VSP)\r\nVXV = (SHM, NMD)\r\nKLC = (XLB, MCH)\r\nJMD = (XQQ, NQQ)\r\nPJN = (FDL, BQC)\r\nPLT = (MCP, VHB)\r\nBGL = (DSC, PSN)\r\nRXH = (SLH, CVN)\r\nVSG = (QVX, SQS)\r\nBDC = (RPS, RBL)\r\nJMM = (XMJ, XDG)\r\nRHK = (QKH, BTX)\r\nRQX = (KSM, PLB)\r\nFQH = (MHT, CDG)\r\nSRM = (PLV, QGV)\r\nHNX = (DSR, KGX)\r\nJNS = (RJN, RXD)\r\nMLP = (JMN, PCR)\r\nLVK = (JHS, QMJ)\r\nPRG = (TJB, MSH)\r\nVGS = (JXR, JLP)\r\nXQQ = (KTJ, BMN)\r\nDGA = (FTD, RGR)\r\nHTX = (MTG, XBV)\r\nCCB = (TXB, VTK)\r\nRQT = (TLR, LDB)\r\nQMX = (SHQ, DPB)\r\nMDS = (KQD, DMC)\r\nJDC = (LCL, SSR)\r\nNHG = (JMD, RQV)\r\nCBM = (DBH, BHQ)\r\nRKB = (VGP, LLP)\r\nSJD = (PLB, KSM)\r\nCDG = (FBC, TJF)\r\nQGV = (TLB, QVB)\r\nBDS = (SPS, BGH)\r\nDGF = (VKH, VKH)\r\nRLV = (MKB, SPP)\r\nSHG = (KQD, DMC)\r\nKQD = (KNV, JBM)\r\nRMV = (DVV, GSF)\r\nMSH = (XXH, TVV)\r\nFJX = (BVG, DJM)\r\nKCV = (PLV, QGV)\r\nMFH = (HCQ, CNF)\r\nTLD = (MCK, KXR)\r\nSLB = (VGP, LLP)\r\nKSN = (HFF, PPV)\r\nRGV = (BDP, KJP)\r\nCNF = (NBF, PCM)\r\nTJF = (GQB, JNP)\r\nNDG = (MTS, JLF)\r\nVHH = (FXM, RJB)\r\nMPH = (CLK, CBH)\r\nRPM = (NXD, LQF)\r\nJHS = (PGH, MXS)\r\nTRJ = (PJF, HJQ)\r\nRJK = (SSR, LCL)\r\nDPB = (SLB, RKB)\r\nXXD = (FFJ, BBX)\r\nQBX = (CRF, VBM)\r\nRMX = (NGM, CPL)\r\nVXT = (MTL, NDG)\r\nKQN = (QQF, RGV)\r\nSFQ = (RLT, RHK)\r\nQGJ = (XDR, PTV)\r\nMSN = (RMV, JLV)\r\nHCQ = (PCM, NBF)\r\nGKF = (PLT, NCP)\r\nVCC = (HLQ, HXQ)\r\nMSJ = (JKP, NLS)\r\nRFF = (BXM, SPH)\r\nFBD = (DGF, VNG)\r\nGLJ = (MQF, RRT)\r\nQRN = (MTH, HBT)\r\nQGS = (TNM, CRD)\r\nXPP = (FNB, CBM)\r\nQQQ = (GHK, DVD)\r\nRBK = (PPQ, XTT)\r\nHHG = (DPL, KFC)\r\nSBP = (FTD, RGR)\r\nMJH = (MLQ, QTG)\r\nJLX = (BDS, TMM)\r\nDVG = (FRH, DCF)\r\nDFJ = (NSK, PDS)\r\nRHJ = (DKM, TDJ)\r\nFQN = (JKT, MVK)\r\nRMD = (LGR, RML)\r\nJTB = (VDP, BSL)\r\nGJM = (NLD, RHJ)\r\nLGP = (CPC, NQN)\r\nJHN = (NBQ, MSJ)\r\nSQF = (BBK, VXF)\r\nHST = (CFM, QMX)\r\nLBJ = (TBP, VNK)\r\nSNX = (PCX, RMX)\r\nPJF = (MGX, SKS)\r\nRRT = (JTB, LSC)\r\nJTT = (MLM, GLJ)\r\nDLQ = (JBQ, RND)\r\nLGR = (QRV, XXD)\r\nLPT = (BSR, SHH)\r\nHQB = (BRL, MXK)\r\nTRP = (LFM, LCT)\r\nJKT = (RNM, TRJ)\r\nMXS = (GQR, KQN)\r\nMKB = (LVQ, NNX)\r\nNDC = (RGK, LVC)\r\nLFN = (RRL, XNF)\r\nSHQ = (RKB, SLB)\r\nJGX = (NGV, HNM)\r\nRPN = (BCL, CDR)\r\nJSJ = (CRH, FHR)\r\nFRH = (THR, TSX)\r\nBNV = (RXS, LGP)\r\nFLL = (GSR, PVF)\r\nDNS = (JLP, JXR)\r\nHDN = (TJX, XMV)\r\nHJQ = (SKS, MGX)\r\nTNX = (SJD, RQX)\r\nXQD = (BFR, MDM)\r\nGNM = (HPQ, SLS)\r\nNML = (DGF, VNG)\r\nBXM = (FJB, FQN)\r\nMSP = (QTG, MLQ)\r\nPBJ = (XLJ, TKD)\r\nMNN = (DNS, VGS)\r\nRBH = (PDS, NSK)\r\nBFJ = (KNT, SDP)\r\nCRD = (PBC, BFK)\r\nTJB = (XXH, TVV)\r\nPDJ = (SRN, SRN)\r\nXJS = (HBG, FRX)\r\nBBK = (LLH, PNP)\r\nQQL = (MFR, KKZ)\r\nFVN = (LGL, SRX)\r\nLRP = (GXT, BSF)\r\nSVX = (MSN, TFG)\r\nPFC = (PCP, FGB)\r\nXMJ = (GKF, GKF)\r\nLLL = (DNS, VGS)\r\nVSX = (TKG, DHL)\r\nRND = (SBC, XFF)\r\nMLQ = (DXT, JMT)\r\nXLC = (TTG, QTK)\r\nTJG = (RXS, LGP)\r\nDPL = (PMF, FSM)\r\nPCR = (CQP, XSJ)\r\nBSQ = (XSD, SVD)\r\nDHP = (HPS, MNQ)\r\nSCB = (HXX, NQV)\r\nFFJ = (LJF, BSV)\r\nFTX = (VTK, TXB)\r\nTRQ = (PCR, JMN)\r\nGDL = (PBD, BJK)\r\nMLM = (RRT, MQF)\r\nTLA = (QXP, MKM)\r\nSMN = (LFN, FVJ)\r\nRRL = (CKJ, JNK)\r\nBDP = (VSP, QFH)\r\nCBC = (DVN, VXT)\r\nJLP = (PTL, SJK)\r\nFRS = (TKG, DHL)\r\nSQQ = (MPL, QBQ)\r\nDVD = (RLK, JPD)\r\nPQP = (LGN, SFD)\r\nFSM = (JDC, RJK)\r\nPSN = (XJS, NRN)\r\nQDN = (SHC, QGJ)\r\nRJN = (XPD, GMS)\r\nHRT = (PPQ, XTT)\r\nCBH = (SRM, KCV)\r\nFSC = (XBV, MTG)\r\nDCX = (CLX, PFC)\r\nXQR = (GSG, JSF)\r\nHBP = (XDT, KNF)\r\nBQJ = (KNT, SDP)\r\nCDJ = (LFM, LCT)\r\nJNK = (MQQ, QJX)\r\nBVP = (MTF, SDC)\r\nTLR = (RHC, NLP)\r\nSJK = (DQP, LMN)\r\nNJG = (MFR, MFR)\r\nRLK = (XCX, PQP)\r\nTPH = (BXH, GSQ)\r\nNSK = (DDS, MLV)\r\nHLQ = (FBV, VNH)\r\nJTP = (FSN, QQQ)\r\nPGH = (KQN, GQR)\r\nSRJ = (PXK, GDL)\r\nTJR = (FHR, CRH)\r\nXDT = (BKJ, PPJ)\r\nGQH = (RLV, THP)\r\nGRS = (BDL, VSG)\r\nDLJ = (CRF, VBM)\r\nVMP = (GJD, NSQ)\r\nMKM = (VTG, BDC)\r\nPVF = (VLX, LBB)\r\nGPV = (SRJ, FNQ)\r\nNTL = (FSN, QQQ)\r\nFQL = (BFR, MDM)\r\nTMJ = (MLM, GLJ)\r\nXKT = (GXT, BSF)\r\nPCX = (NGM, CPL)\r\nXMV = (HQB, JRJ)\r\nQKH = (FLL, JJG)\r\nVQP = (FLG, DDL)\r\nSLS = (CKK, HVF)\r\nTHM = (RDQ, DVG)\r\nPPJ = (GCT, TNX)\r\nTMM = (BGH, SPS)\r\nGVL = (PCG, RQS)\r\nDCF = (TSX, THR)\r\nBJK = (FRS, VSX)\r\nSPP = (NNX, LVQ)\r\nQGX = (QMJ, JHS)\r\nRPV = (HGR, DHP)\r\nMTG = (DGJ, QJN)\r\nKGL = (XGD, MQC)\r\nDHD = (RND, JBQ)\r\nBXD = (KFH, HTM)\r\nKGX = (MPD, BST)\r\nQVB = (LKT, RGT)\r\nCBK = (RDG, PKT)\r\nBTB = (JMJ, CTD)\r\nFSN = (DVD, GHK)\r\nKXR = (FFT, DVQ)\r\nTML = (GPV, PVN)\r\nVXF = (PNP, LLH)\r\nDBH = (SQF, VMB)\r\nFCP = (JKK, LFD)\r\nRXQ = (DJN, RFJ)\r\nNTH = (SDC, MTF)\r\nJBM = (SVX, JBD)\r\nPNN = (FJX, SLZ)\r\nGQR = (QQF, RGV)\r\nPXR = (LRP, XKT)\r\nVRK = (RDJ, SMN)\r\nLDB = (RHC, NLP)\r\nLHV = (RXH, ZZZ)\r\nFNB = (DBH, BHQ)\r\nMFM = (VMP, GQC)\r\nPGV = (PKT, RDG)\r\nSPR = (XJP, SHD)\r\nCCR = (LQF, NXD)\r\nGJC = (XRQ, PQB)\r\nLGN = (GRS, DLD)\r\nRDG = (FBD, NML)\r\nMCP = (DLC, TGK)\r\nNMD = (XFR, GRK)\r\nMVK = (TRJ, RNM)\r\nJKF = (TFX, KHJ)\r\nXFR = (SMG, JNQ)\r\nNGM = (XPX, JLX)\r\nMFD = (GVL, MBR)\r\nRNT = (CDR, BCL)\r\nVVX = (XMJ, XMJ)\r\nGNC = (HST, GJR)\r\nCRF = (PBK, GJM)\r\nJKK = (GCQ, SGC)\r\nGBH = (QDR, RFF)\r\nFJG = (XMQ, KSN)\r\nGDV = (GQN, GXH)\r\nXLB = (FMN, JVN)\r\nKNV = (JBD, SVX)\r\nPXX = (HHG, TTQ)\r\nTDJ = (MFD, QJT)\r\nQLG = (PJN, VFS)\r\nNRN = (HBG, FRX)\r\nSHM = (GRK, XFR)\r\nFHV = (HXX, NQV)\r\nQFH = (GNC, CHX)\r\nPCM = (QLQ, MPH)\r\nVLX = (QMR, PBJ)\r\nRPP = (HRT, RBK)\r\nJXR = (SJK, PTL)\r\nLPQ = (QDR, RFF)\r\nBFR = (STC, PJT)\r\nXTT = (CBC, DSH)\r\nHVF = (VTD, KDC)\r\nJFJ = (FCP, BHF)\r\nLVQ = (PRG, MQP)\r\nJFD = (RBH, DFJ)\r\nHFM = (TPJ, JGX)\r\nBSV = (XQR, PMH)\r\nJLC = (GGR, TFM)\r\nNSQ = (FHV, SCB)\r\nNCP = (VHB, MCP)\r\nJKB = (LDB, TLR)\r\nBLX = (PDJ, GBX)\r\nSVP = (BQJ, BFJ)\r\nVSP = (CHX, GNC)\r\nSPH = (FJB, FQN)\r\nRPS = (VNF, BXD)\r\nQMR = (TKD, XLJ)\r\nQMJ = (MXS, PGH)\r\nJNB = (LGL, SRX)\r\nRGM = (JTP, NTL)\r\nGHK = (JPD, RLK)\r\nTFX = (NJG, NJG)\r\nNBQ = (JKP, NLS)\r\nNTX = (VFS, PJN)\r\nQTS = (RQV, JMD)\r\nLMN = (DSS, PBL)\r\nCLK = (SRM, KCV)\r\nMPD = (RMD, DRB)\r\nPDS = (DDS, MLV)\r\nNNX = (PRG, MQP)\r\nBST = (DRB, RMD)\r\nDSG = (SGV, DVB)\r\nKDC = (QVL, KLC)\r\nVKX = (PSN, DSC)\r\nLJM = (DBB, QXN)\r\nVFV = (SHC, QGJ)\r\nFXR = (RJN, RXD)\r\nHGR = (HPS, MNQ)\r\nBMN = (CCR, RPM)\r\nCRH = (FSC, HTX)\r\nQRV = (BBX, FFJ)\r\nCKK = (VTD, KDC)\r\nSDP = (RNT, RPN)\r\nXLJ = (JTX, QRN)\r\nBSL = (PFL, GLN)\r\nGJD = (FHV, SCB)\r\nVNH = (DCJ, CXG)\r\nBCB = (MXJ, LVR)\r\nNBF = (MPH, QLQ)\r\nMCK = (DVQ, FFT)\r\nRFJ = (HFM, JFK)\r\nBBD = (LJM, NXN)\r\nFMN = (SPR, DMJ)\r\nJXK = (GPK, VQP)\r\nSLL = (MHT, CDG)\r\nTRR = (GNM, CSC)\r\nMJC = (KXR, MCK)\r\nMHT = (FBC, TJF)\r\nTSF = (HDH, RGM)\r\nFLG = (FQL, XQD)\r\nMGX = (SLL, FQH)\r\nRGR = (NMN, PXX)\r\nRDA = (BVG, DJM)\r\nVXX = (DHD, DLQ)\r\nDXT = (BNV, TJG)\r\nLCL = (DHV, NHN)\r\nCKB = (FNN, FKT)\r\nKNH = (LVR, MXJ)\r\nGSQ = (PGR, NDC)\r\nCFM = (DPB, SHQ)\r\nHDH = (JTP, NTL)\r\nNSF = (VFV, QDN)\r\nHSF = (KSJ, KBM)\r\nGSR = (VLX, LBB)\r\nGCT = (RQX, SJD)\r\nRBN = (XDT, KNF)\r\nXNF = (JNK, CKJ)\r\nTCF = (RBK, HRT)\r\nDPA = (MDS, SHG)\r\nQTG = (JMT, DXT)\r\nRGT = (SBP, BSZ)\r\nXCX = (SFD, LGN)\r\nKSJ = (KDR, GKG)\r\nGQN = (QGX, LVK)\r\nMDM = (PJT, STC)\r\nKKZ = (MKM, QXP)\r\nMQC = (JQL, TML)\r\nVFS = (FDL, BQC)\r\nTJX = (JRJ, HQB)\r\nBSF = (MTT, JFP)\r\nVMD = (PQH, VHC)\r\nJTX = (HBT, MTH)\r\nMCH = (FMN, JVN)\r\nVBK = (MSJ, NBQ)\r\nTBP = (GBH, LPQ)\r\nTVX = (VQP, GPK)\r\nNQN = (SVP, PGB)\r\nSMG = (XLC, NVB)\r\nSHD = (BCB, KNH)\r\nJLF = (SQX, GJC)\r\nGSF = (QTS, NHG)\r\nBDN = (PNX, RGP)\r\nGRK = (SMG, JNQ)\r\nPLV = (TLB, TLB)\r\nSQS = (HTJ, VRH)\r\nPDH = (FXM, RJB)\r\nVGP = (LLL, MNN)\r\nJRQ = (TVT, BLX)\r\nCLX = (PCP, FGB)\r\nPMF = (JDC, RJK)\r\nJRJ = (BRL, MXK)\r\nXMQ = (PPV, HFF)\r\nBVT = (RQT, JKB)\r\nFJT = (BXH, GSQ)\r\nFRT = (TNC, PXR)\r\nQVL = (XLB, MCH)\r\nTNM = (BFK, PBC)\r\nXPX = (BDS, TMM)\r\nXCN = (SHH, BSR)\r\nPKT = (FBD, NML)\r\nTLB = (LKT, LKT)\r\nTFG = (RMV, JLV)\r\nSRN = (MDS, SHG)\r\nFRC = (BHF, FCP)\r\nGGR = (RTC, DKJ)\r\nKFH = (JXK, TVX)\r\nJNQ = (XLC, NVB)\r\nMTF = (RGC, THM)\r\nSTT = (RDJ, SMN)\r\nCPL = (XPX, JLX)\r\nFGB = (XPP, QQR)\r\nDLC = (RPP, TCF)\r\nDJM = (QXH, BSQ)\r\nMBH = (SGS, LBJ)\r\nVBD = (RMX, PCX)\r\nCXG = (TRP, CDJ)\r\nNGV = (VMD, BQX)\r\nGQB = (DRN, NXS)\r\nFHR = (HTX, FSC)\r\nDDL = (FQL, XQD)\r\nFBC = (JNP, GQB)\r\nDKJ = (TPH, FJT)\r\nRQB = (GQN, GXH)\r\nLPM = (RDD, MRD)\r\nBKJ = (GCT, TNX)\r\nGMS = (PDH, VHH)\r\nHTM = (JXK, TVX)\r\nPPQ = (CBC, DSH)\r\nMBR = (RQS, PCG)\r\nPJT = (FGJ, QGS)\r\nPQH = (RBN, HBP)\r\nCBT = (RXH, RXH)\r\nCHX = (HST, GJR)\r\nBQC = (JCT, TRR)\r\nNJK = (JMJ, CTD)\r\nQVX = (VRH, HTJ)\r\nKKM = (FTX, CCB)\r\nNXN = (DBB, QXN)\r\nJQL = (GPV, PVN)\r\nMFR = (QXP, MKM)\r\nVML = (HGR, DHP)\r\nPCJ = (THP, RLV)\r\nXRQ = (BVP, NTH)\r\nPXK = (PBD, BJK)\r\nHCX = (HFS, HSF)\r\nQJT = (MBR, GVL)\r\nRLT = (BTX, QKH)\r\nDKG = (QBQ, MPL)\r\nCQP = (TSF, MVT)\r\nHFF = (VBD, SNX)\r\nKNF = (BKJ, PPJ)\r\nFFT = (JFJ, FRC)\r\nDDS = (PGK, DSG)\r\nPFL = (SGB, SFQ)\r\nRXS = (CPC, NQN)\r\nXSV = (XCN, LPT)\r\nMNQ = (VXV, RFQ)\r\nPVN = (SRJ, FNQ)\r\nVNF = (KFH, HTM)\r\nHPQ = (HVF, CKK)\r\nPGK = (DVB, SGV)\r\nVHC = (HBP, RBN)\r\nGBX = (SRN, RXZ)\r\nSGV = (CBK, PGV)\r\nTVV = (QLG, NTX)\r\nKNT = (RPN, RNT)\r\nTXB = (NSF, QJM)\r\nPCP = (XPP, QQR)\r\nPCG = (BDV, VXX)\r\nMQF = (LSC, JTB)\r\nQJN = (CKB, QSX)\r\nQXH = (SVD, XSD)\r\nLCT = (PCJ, GQH)\r\nGKG = (HDN, HJJ)\r\nTKD = (JTX, QRN)\r\nKBQ = (XCN, LPT)\r\nKSM = (VKX, BGL)\r\nMQQ = (NQP, NVQ)\r\nVFF = (HFS, HSF)\r\nSSX = (TVT, TVT)\r\nDSS = (VVX, VVX)\r\nQDR = (SPH, BXM)\r\nPGR = (RGK, RGK)\r\nRML = (QRV, XXD)\r\nXDR = (JNS, FXR)\r\nDVB = (PGV, CBK)\r\nTSX = (QBX, DLJ)\r\nQBQ = (TJR, JSJ)\r\nBBX = (LJF, BSV)\r\nPTL = (DQP, LMN)\r\nPBC = (BBD, SKJ)\r\nVHB = (DLC, TGK)\r\nXJP = (BCB, KNH)\r\nSTC = (QGS, FGJ)\r\nFNQ = (PXK, GDL)\r\nMXJ = (LHK, BBB)\r\nJNP = (NXS, DRN)\r\nSGS = (TBP, VNK)\r\nRFQ = (SHM, NMD)\r\nMLV = (DSG, PGK)\r\nCDR = (VBK, JHN)\r\nCTD = (DCX, BNG)\r\nFRD = (FJX, FJX)\r\nGCQ = (FCH, JLC)\r\nNXS = (KGL, LTN)\r\nJBQ = (SBC, XFF)\r\nNLD = (DKM, TDJ)\r\nVTG = (RBL, RPS)\r\nJJG = (GSR, PVF)\r\nDKM = (QJT, MFD)\r\nRDJ = (LFN, FVJ)\r\nKTJ = (RPM, CCR)\r\nGSG = (FRT, MVG)\r\nMTL = (JLF, MTS)\r\nPNP = (RPV, VML)\r\nTTG = (MBH, GJX)\r\nLSC = (VDP, BSL)\r\nTHR = (DLJ, QBX)\r\nNQV = (BVT, XQK)\r\nLBB = (PBJ, QMR)\r\nNQQ = (KTJ, BMN)\r\nDMJ = (XJP, SHD)\r\nDSC = (XJS, NRN)\r\nRXD = (GMS, XPD)\r\nKBM = (GKG, KDR)\r\nLLP = (LLL, MNN)\r\nHNM = (VMD, BQX)\r\nVNG = (VKH, SCV)\r\nXDG = (GKF, CTZ)\r\nPNX = (MFM, JJP)\r\nPBK = (RHJ, NLD)\r\nBVR = (CNF, HCQ)\r\nDHV = (VCC, RXL)\r\nTGK = (RPP, TCF)\r\nRDD = (NJK, BTB)\r\nNMN = (HHG, TTQ)\r\nHJF = (HPJ, SFK)\r\nBDV = (DLQ, DHD)\r\nTVT = (PDJ, PDJ)\r\nBGH = (TRQ, MLP)\r\nFVJ = (RRL, XNF)\r\nDBB = (KKM, CGV)";
            string demo1 = "RL\r\n\r\nAAA = (BBB, CCC)\r\nBBB = (DDD, EEE)\r\nCCC = (ZZZ, GGG)\r\nDDD = (DDD, DDD)\r\nEEE = (EEE, EEE)\r\nGGG = (GGG, GGG)\r\nZZZ = (ZZZ, ZZZ)";
            string demo2 = "LLR\r\n\r\nAAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)";
            string demo3 = "LR\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22Z)\r\n22Z = (22B, 22B)\r\nXXX = (XXX, XXX)";
            string demo4 = "LRRRL\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22B)\r\n22Z = (22B, 22B)\r\nXXX = (22A, 11Z)";


            string[] temp = input.Split("\r\n\r\n");

            string directions = temp[0];
            string[] network = temp[1].Split("\r\n");
            int st = directions.Length;

            List<Pointer> pointerList = new List<Pointer>();
            List<Pointer> possinions = new List<Pointer>();
            List<string> targers = new List<string>();
            void Setup()
            {
                foreach (string line in network)
                {
                    string[] split = line.Replace(" =", "").Replace("(", "").Replace(",", "").Replace(")", "").Split(' ');

                    Pointer pointer = pointerList.FirstOrDefault(p => p.Id == split[0]);
                    if (pointer is null)
                    {
                        pointer = new Pointer();
                        pointer.Id = split[0];
                        pointerList.Add(pointer);
                    }
                    Pointer tooLeft = pointerList.FirstOrDefault(p => p.Id == split[1]);
                    if (tooLeft is null)
                    {
                        tooLeft = new Pointer();
                        tooLeft.Id = split[1];
                        pointerList.Add(tooLeft);
                    }
                    Pointer tooRight = pointerList.FirstOrDefault(p => p.Id == split[2]);
                    if (tooRight is null)
                    {
                        tooRight = new Pointer();
                        tooRight.Id = split[2];
                        pointerList.Add(tooRight);
                    }

                    pointer.Left = tooLeft;
                    pointer.Right = tooRight;


                    if (pointer.Id.Last() == 'A')
                    {
                        possinions.Add(pointer);
                    }
                    else if (pointer.Id.Last() == 'Z')
                    {
                        targers.Add(pointer.Id);
                    }
                }
            }
            Setup();

            // start calculating
            var start = DateTime.Now;

            long count = 0;
            int steps = 0;


            Dictionary<string, List<long>[]> targetHits = new Dictionary<string, List<long>[]>();
            foreach (var target in targers)
            {
                targetHits.Add(target, new List<long>[possinions.Count]);
                for (var i = 0; i < possinions.Count; i++)
                {
                    targetHits[target][i] = new List<long>();
                }
            }


            bool found = false;
            do
            {
                // found = false;

                if (directions[steps] == 'R')
                {

                    for (int i = 0; i < possinions.Count; i++)
                    {
                        possinions[i] = possinions[i].Right;

                    }
                }
                else
                {
                    for (int i = 0; i < possinions.Count; i++)
                    {
                        possinions[i] = possinions[i].Left;
                    }
                }


                //if (possinions[0].Id.Last() == 'Z')
                if (false)
                {

                    found = true;


                    foreach (Pointer possition in possinions)
                    {
                        if (possition.Id.Last() != 'Z')
                        {
                            found = false;
                            // break;
                        }
                        else
                        {
                            Console.Write(possition.Id + " - ");

                        }

                    }
                    Console.WriteLine(steps + " - " + count);
                }

                // ZZZ [0]

                // CTZ [1] appears every 
                // 5608
                //11217
                //16826
                //22435

                // BSZ [2]
                //263622
                //527245

                // ???
                // RXZ
                // KKZ
                // SLZ






                steps++;
                if (steps == directions.Length)
                {

                    for (int j = 0; j < possinions.Count; j++)
                    {
                        if (possinions[j].Id.Last() == 'Z')
                        {
                            targetHits[possinions[j].Id][j].Add(count);
                        }


                        // ZZZ [0] 79

                        // CTZ [1] 71

                        // BSZ [2] 47

                        // KKZ [3] 53

                        // SLZ [4] 67

                        // RXZ [5] 43


                    }




                    //if (possinions[0].Id.Last() == 'Z')
                    //{

                    //    found = true;


                    //    foreach (Pointer possition in possinions)
                    //    {
                    //        if (possition.Id.Last() != 'Z')
                    //        {
                    //            found = false;
                    //            // break;
                    //        }
                    //        else
                    //        {
                    //            Console.Write(possition.Id + " - ");

                    //        }

                    //    }
                    //    Console.WriteLine(steps + " - " + count);
                    //}


                    count++;
                    steps = 0;

                    if (count % 12000 == 0)
                    {
                        Console.WriteLine(DateTime.Now.Ticks - start.Ticks + "\t- " + (steps + (count * directions.Length)));
                        //break;
                        // count 12.000 IN:
                        // 12133370
                        //  8356016
                        //  4999631
                        //  4367279


                    }
                }

            } while (!found);



            Console.WriteLine(DateTime.Now.Ticks - start.Ticks);
            Console.WriteLine(steps + count * directions.Length);
            Console.ReadLine();

            // 160622400000 to low
            // 12357789728873 is right

            // publish version is doing 942 steps per tick

        }
        public void Part2Try1()
        {
            Console.WriteLine("Start");
            string input = "LRLRLLRRLLRRLRRLRRRLLRLRLRLRLRRLRRRLRLRRLRLLRRLLRLRRLRLRRLLRRRLRLRLRRRLRLLRRRLLLLLLRRRLRRLLLRRLRLRRLRRLRLRRLRRLLRRLRRRLRRRLLRLRLLLRRLLLRRLLRRLRLLRRRLRRRLRRRLRLRRLRRLLLRRRLRRLLRRLRRRLRLRLRRLRRLRRRLRRRLRLLLLRRRLRLRRRLRRRLLRLRRLRRLLRLLLRRLRLRRLRRRLRRRLRRRLLRRRLRLLRRRLRRRLRRRLRRRLRRLRRRLLRRLLRLRLRRRLRRRLRLRRRR\r\n\r\nLFM = (PCJ, GQH)\r\nTHP = (SPP, MKB)\r\nPBL = (VVX, JMM)\r\nDSR = (BST, MPD)\r\nQKF = (DSR, KGX)\r\nAAA = (SLH, CVN)\r\nDSH = (DVN, VXT)\r\nVTK = (NSF, QJM)\r\nQQR = (FNB, CBM)\r\nRQV = (XQQ, NQQ)\r\nCGV = (CCB, FTX)\r\nRXL = (HXQ, HLQ)\r\nMQP = (MSH, TJB)\r\nMPL = (JSJ, TJR)\r\nXQK = (RQT, JKB)\r\nGXT = (JFP, MTT)\r\nLHK = (BVR, MFH)\r\nBXH = (PGR, NDC)\r\nFFV = (MJC, TLD)\r\nTFM = (DKJ, RTC)\r\nMVG = (TNC, PXR)\r\nQXN = (CGV, KKM)\r\nLTN = (MQC, XGD)\r\nNLP = (SQQ, DKG)\r\nQTK = (MBH, GJX)\r\nSSR = (DHV, NHN)\r\nDGJ = (QSX, CKB)\r\nSFD = (GRS, DLD)\r\nHBT = (NVN, HJF)\r\nVKH = (CBT, CBT)\r\nVRH = (FVN, JNB)\r\nHTJ = (JNB, FVN)\r\nBDL = (SQS, QVX)\r\nMMC = (MJC, TLD)\r\nRBL = (VNF, BXD)\r\nRNM = (HJQ, PJF)\r\nCTZ = (NCP, PLT)\r\nJFK = (TPJ, JGX)\r\nHPJ = (MMC, FFV)\r\nRJC = (RBH, DFJ)\r\nDHL = (RJC, JFD)\r\nLVR = (BBB, LHK)\r\nLFD = (GCQ, SGC)\r\nBVG = (BSQ, QXH)\r\nDVN = (MTL, NDG)\r\nXGD = (TML, JQL)\r\nRQS = (VXX, BDV)\r\nCPC = (PGB, SVP)\r\nQLQ = (CLK, CBH)\r\nRXZ = (SHG, MDS)\r\nNTR = (RGP, PNX)\r\nBBB = (MFH, BVR)\r\nRGK = (FRD, FRD)\r\nJLV = (DVV, GSF)\r\nNLS = (VFF, HCX)\r\nRHC = (DKG, SQQ)\r\nNVB = (TTG, QTK)\r\nSLZ = (DJM, BVG)\r\nBFK = (SKJ, BBD)\r\nHXX = (XQK, BVT)\r\nSKS = (SLL, FQH)\r\nSGB = (RLT, RHK)\r\nNPD = (RFJ, DJN)\r\nXSJ = (TSF, MVT)\r\nLLH = (RPV, VML)\r\nNXD = (DJS, FJG)\r\nGJX = (SGS, LBJ)\r\nFBV = (CXG, DCJ)\r\nFRX = (GDV, RQB)\r\nSDC = (RGC, THM)\r\nJCT = (CSC, GNM)\r\nSPS = (MLP, TRQ)\r\nBNG = (PFC, CLX)\r\nSHH = (LPM, VRC)\r\nSGC = (FCH, JLC)\r\nFJB = (MVK, JKT)\r\nDRN = (KGL, LTN)\r\nRJB = (NTR, BDN)\r\nDMC = (JBM, KNV)\r\nHBG = (RQB, GDV)\r\nVRC = (RDD, MRD)\r\nJJP = (GQC, VMP)\r\nPLB = (VKX, BGL)\r\nDVV = (QTS, NHG)\r\nLGL = (SSX, JRQ)\r\nRGC = (DVG, RDQ)\r\nGPK = (DDL, FLG)\r\nNVN = (HPJ, SFK)\r\nDVQ = (JFJ, FRC)\r\nVDP = (PFL, GLN)\r\nCVN = (HNX, QKF)\r\nQXP = (VTG, BDC)\r\nLKT = (SBP, SBP)\r\nQSX = (FNN, FKT)\r\nCSC = (HPQ, SLS)\r\nFNN = (DCV, JKF)\r\nMTH = (NVN, HJF)\r\nTPJ = (HNM, NGV)\r\nNHN = (VCC, RXL)\r\nBHF = (JKK, LFD)\r\nHXQ = (VNH, FBV)\r\nKDR = (HDN, HJJ)\r\nSVD = (VRK, STT)\r\nFGJ = (TNM, CRD)\r\nXFF = (NPD, RXQ)\r\nTNC = (XKT, LRP)\r\nVBM = (GJM, PBK)\r\nXBV = (DGJ, QJN)\r\nGXH = (LVK, QGX)\r\nSLH = (HNX, QKF)\r\nZZZ = (CVN, SLH)\r\nRTC = (TPH, FJT)\r\nNQP = (MJH, MSP)\r\nXSD = (STT, VRK)\r\nHJJ = (XMV, TJX)\r\nJFP = (XSV, KBQ)\r\nFTD = (NMN, PXX)\r\nNVQ = (MSP, MJH)\r\nSHC = (PTV, XDR)\r\nDCV = (TFX, TFX)\r\nBTX = (JJG, FLL)\r\nRDQ = (DCF, FRH)\r\nMTT = (KBQ, XSV)\r\nDRB = (RML, LGR)\r\nPBD = (VSX, FRS)\r\nHFS = (KBM, KSJ)\r\nSKJ = (NXN, LJM)\r\nMTS = (GJC, SQX)\r\nBRL = (TMJ, JTT)\r\nTTQ = (KFC, DPL)\r\nLQF = (DJS, FJG)\r\nTKG = (JFD, RJC)\r\nPGB = (BFJ, BQJ)\r\nBQX = (VHC, PQH)\r\nMRD = (BTB, NJK)\r\nLJF = (XQR, PMH)\r\nBCL = (VBK, JHN)\r\nBHQ = (VMB, SQF)\r\nBSR = (LPM, VRC)\r\nVNK = (GBH, LPQ)\r\nKHJ = (NJG, QQL)\r\nVMB = (BBK, VXF)\r\nQJM = (QDN, VFV)\r\nKFC = (FSM, PMF)\r\nJVN = (DMJ, SPR)\r\nMVT = (RGM, HDH)\r\nPQB = (BVP, NTH)\r\nQQF = (KJP, BDP)\r\nRGP = (JJP, MFM)\r\nDLD = (VSG, BDL)\r\nSCV = (CBT, LHV)\r\nVTD = (KLC, QVL)\r\nFCH = (GGR, TFM)\r\nGJR = (QMX, CFM)\r\nPMH = (GSG, JSF)\r\nDCJ = (CDJ, TRP)\r\nQJX = (NVQ, NQP)\r\nDJN = (JFK, HFM)\r\nDQP = (DSS, PBL)\r\nXXH = (NTX, QLG)\r\nMXK = (JTT, TMJ)\r\nFDL = (JCT, TRR)\r\nMGA = (PLT, NCP)\r\nHPS = (RFQ, VXV)\r\nSBC = (NPD, RXQ)\r\nXPD = (VHH, PDH)\r\nSRX = (SSX, JRQ)\r\nCKJ = (MQQ, QJX)\r\nFKT = (DCV, JKF)\r\nJKP = (VFF, HCX)\r\nJMN = (XSJ, CQP)\r\nGLN = (SFQ, SGB)\r\nPTV = (JNS, FXR)\r\nFXM = (NTR, BDN)\r\nDJS = (XMQ, KSN)\r\nLVC = (FRD, PNN)\r\nJPD = (PQP, XCX)\r\nGQC = (NSQ, GJD)\r\nSFK = (FFV, MMC)\r\nJBD = (TFG, MSN)\r\nBSZ = (RGR, FTD)\r\nSQX = (XRQ, PQB)\r\nPPV = (VBD, SNX)\r\nJSF = (FRT, MVG)\r\nJMT = (TJG, BNV)\r\nJMJ = (DCX, BNG)\r\nKJP = (QFH, VSP)\r\nVXV = (SHM, NMD)\r\nKLC = (XLB, MCH)\r\nJMD = (XQQ, NQQ)\r\nPJN = (FDL, BQC)\r\nPLT = (MCP, VHB)\r\nBGL = (DSC, PSN)\r\nRXH = (SLH, CVN)\r\nVSG = (QVX, SQS)\r\nBDC = (RPS, RBL)\r\nJMM = (XMJ, XDG)\r\nRHK = (QKH, BTX)\r\nRQX = (KSM, PLB)\r\nFQH = (MHT, CDG)\r\nSRM = (PLV, QGV)\r\nHNX = (DSR, KGX)\r\nJNS = (RJN, RXD)\r\nMLP = (JMN, PCR)\r\nLVK = (JHS, QMJ)\r\nPRG = (TJB, MSH)\r\nVGS = (JXR, JLP)\r\nXQQ = (KTJ, BMN)\r\nDGA = (FTD, RGR)\r\nHTX = (MTG, XBV)\r\nCCB = (TXB, VTK)\r\nRQT = (TLR, LDB)\r\nQMX = (SHQ, DPB)\r\nMDS = (KQD, DMC)\r\nJDC = (LCL, SSR)\r\nNHG = (JMD, RQV)\r\nCBM = (DBH, BHQ)\r\nRKB = (VGP, LLP)\r\nSJD = (PLB, KSM)\r\nCDG = (FBC, TJF)\r\nQGV = (TLB, QVB)\r\nBDS = (SPS, BGH)\r\nDGF = (VKH, VKH)\r\nRLV = (MKB, SPP)\r\nSHG = (KQD, DMC)\r\nKQD = (KNV, JBM)\r\nRMV = (DVV, GSF)\r\nMSH = (XXH, TVV)\r\nFJX = (BVG, DJM)\r\nKCV = (PLV, QGV)\r\nMFH = (HCQ, CNF)\r\nTLD = (MCK, KXR)\r\nSLB = (VGP, LLP)\r\nKSN = (HFF, PPV)\r\nRGV = (BDP, KJP)\r\nCNF = (NBF, PCM)\r\nTJF = (GQB, JNP)\r\nNDG = (MTS, JLF)\r\nVHH = (FXM, RJB)\r\nMPH = (CLK, CBH)\r\nRPM = (NXD, LQF)\r\nJHS = (PGH, MXS)\r\nTRJ = (PJF, HJQ)\r\nRJK = (SSR, LCL)\r\nDPB = (SLB, RKB)\r\nXXD = (FFJ, BBX)\r\nQBX = (CRF, VBM)\r\nRMX = (NGM, CPL)\r\nVXT = (MTL, NDG)\r\nKQN = (QQF, RGV)\r\nSFQ = (RLT, RHK)\r\nQGJ = (XDR, PTV)\r\nMSN = (RMV, JLV)\r\nHCQ = (PCM, NBF)\r\nGKF = (PLT, NCP)\r\nVCC = (HLQ, HXQ)\r\nMSJ = (JKP, NLS)\r\nRFF = (BXM, SPH)\r\nFBD = (DGF, VNG)\r\nGLJ = (MQF, RRT)\r\nQRN = (MTH, HBT)\r\nQGS = (TNM, CRD)\r\nXPP = (FNB, CBM)\r\nQQQ = (GHK, DVD)\r\nRBK = (PPQ, XTT)\r\nHHG = (DPL, KFC)\r\nSBP = (FTD, RGR)\r\nMJH = (MLQ, QTG)\r\nJLX = (BDS, TMM)\r\nDVG = (FRH, DCF)\r\nDFJ = (NSK, PDS)\r\nRHJ = (DKM, TDJ)\r\nFQN = (JKT, MVK)\r\nRMD = (LGR, RML)\r\nJTB = (VDP, BSL)\r\nGJM = (NLD, RHJ)\r\nLGP = (CPC, NQN)\r\nJHN = (NBQ, MSJ)\r\nSQF = (BBK, VXF)\r\nHST = (CFM, QMX)\r\nLBJ = (TBP, VNK)\r\nSNX = (PCX, RMX)\r\nPJF = (MGX, SKS)\r\nRRT = (JTB, LSC)\r\nJTT = (MLM, GLJ)\r\nDLQ = (JBQ, RND)\r\nLGR = (QRV, XXD)\r\nLPT = (BSR, SHH)\r\nHQB = (BRL, MXK)\r\nTRP = (LFM, LCT)\r\nJKT = (RNM, TRJ)\r\nMXS = (GQR, KQN)\r\nMKB = (LVQ, NNX)\r\nNDC = (RGK, LVC)\r\nLFN = (RRL, XNF)\r\nSHQ = (RKB, SLB)\r\nJGX = (NGV, HNM)\r\nRPN = (BCL, CDR)\r\nJSJ = (CRH, FHR)\r\nFRH = (THR, TSX)\r\nBNV = (RXS, LGP)\r\nFLL = (GSR, PVF)\r\nDNS = (JLP, JXR)\r\nHDN = (TJX, XMV)\r\nHJQ = (SKS, MGX)\r\nTNX = (SJD, RQX)\r\nXQD = (BFR, MDM)\r\nGNM = (HPQ, SLS)\r\nNML = (DGF, VNG)\r\nBXM = (FJB, FQN)\r\nMSP = (QTG, MLQ)\r\nPBJ = (XLJ, TKD)\r\nMNN = (DNS, VGS)\r\nRBH = (PDS, NSK)\r\nBFJ = (KNT, SDP)\r\nCRD = (PBC, BFK)\r\nTJB = (XXH, TVV)\r\nPDJ = (SRN, SRN)\r\nXJS = (HBG, FRX)\r\nBBK = (LLH, PNP)\r\nQQL = (MFR, KKZ)\r\nFVN = (LGL, SRX)\r\nLRP = (GXT, BSF)\r\nSVX = (MSN, TFG)\r\nPFC = (PCP, FGB)\r\nXMJ = (GKF, GKF)\r\nLLL = (DNS, VGS)\r\nVSX = (TKG, DHL)\r\nRND = (SBC, XFF)\r\nMLQ = (DXT, JMT)\r\nXLC = (TTG, QTK)\r\nTJG = (RXS, LGP)\r\nDPL = (PMF, FSM)\r\nPCR = (CQP, XSJ)\r\nBSQ = (XSD, SVD)\r\nDHP = (HPS, MNQ)\r\nSCB = (HXX, NQV)\r\nFFJ = (LJF, BSV)\r\nFTX = (VTK, TXB)\r\nTRQ = (PCR, JMN)\r\nGDL = (PBD, BJK)\r\nMLM = (RRT, MQF)\r\nTLA = (QXP, MKM)\r\nSMN = (LFN, FVJ)\r\nRRL = (CKJ, JNK)\r\nBDP = (VSP, QFH)\r\nCBC = (DVN, VXT)\r\nJLP = (PTL, SJK)\r\nFRS = (TKG, DHL)\r\nSQQ = (MPL, QBQ)\r\nDVD = (RLK, JPD)\r\nPQP = (LGN, SFD)\r\nFSM = (JDC, RJK)\r\nPSN = (XJS, NRN)\r\nQDN = (SHC, QGJ)\r\nRJN = (XPD, GMS)\r\nHRT = (PPQ, XTT)\r\nCBH = (SRM, KCV)\r\nFSC = (XBV, MTG)\r\nDCX = (CLX, PFC)\r\nXQR = (GSG, JSF)\r\nHBP = (XDT, KNF)\r\nBQJ = (KNT, SDP)\r\nCDJ = (LFM, LCT)\r\nJNK = (MQQ, QJX)\r\nBVP = (MTF, SDC)\r\nTLR = (RHC, NLP)\r\nSJK = (DQP, LMN)\r\nNJG = (MFR, MFR)\r\nRLK = (XCX, PQP)\r\nTPH = (BXH, GSQ)\r\nNSK = (DDS, MLV)\r\nHLQ = (FBV, VNH)\r\nJTP = (FSN, QQQ)\r\nPGH = (KQN, GQR)\r\nSRJ = (PXK, GDL)\r\nTJR = (FHR, CRH)\r\nXDT = (BKJ, PPJ)\r\nGQH = (RLV, THP)\r\nGRS = (BDL, VSG)\r\nDLJ = (CRF, VBM)\r\nVMP = (GJD, NSQ)\r\nMKM = (VTG, BDC)\r\nPVF = (VLX, LBB)\r\nGPV = (SRJ, FNQ)\r\nNTL = (FSN, QQQ)\r\nFQL = (BFR, MDM)\r\nTMJ = (MLM, GLJ)\r\nXKT = (GXT, BSF)\r\nPCX = (NGM, CPL)\r\nXMV = (HQB, JRJ)\r\nQKH = (FLL, JJG)\r\nVQP = (FLG, DDL)\r\nSLS = (CKK, HVF)\r\nTHM = (RDQ, DVG)\r\nPPJ = (GCT, TNX)\r\nTMM = (BGH, SPS)\r\nGVL = (PCG, RQS)\r\nDCF = (TSX, THR)\r\nBJK = (FRS, VSX)\r\nSPP = (NNX, LVQ)\r\nQGX = (QMJ, JHS)\r\nRPV = (HGR, DHP)\r\nMTG = (DGJ, QJN)\r\nKGL = (XGD, MQC)\r\nDHD = (RND, JBQ)\r\nBXD = (KFH, HTM)\r\nKGX = (MPD, BST)\r\nQVB = (LKT, RGT)\r\nCBK = (RDG, PKT)\r\nBTB = (JMJ, CTD)\r\nFSN = (DVD, GHK)\r\nKXR = (FFT, DVQ)\r\nTML = (GPV, PVN)\r\nVXF = (PNP, LLH)\r\nDBH = (SQF, VMB)\r\nFCP = (JKK, LFD)\r\nRXQ = (DJN, RFJ)\r\nNTH = (SDC, MTF)\r\nJBM = (SVX, JBD)\r\nPNN = (FJX, SLZ)\r\nGQR = (QQF, RGV)\r\nPXR = (LRP, XKT)\r\nVRK = (RDJ, SMN)\r\nLDB = (RHC, NLP)\r\nLHV = (RXH, ZZZ)\r\nFNB = (DBH, BHQ)\r\nMFM = (VMP, GQC)\r\nPGV = (PKT, RDG)\r\nSPR = (XJP, SHD)\r\nCCR = (LQF, NXD)\r\nGJC = (XRQ, PQB)\r\nLGN = (GRS, DLD)\r\nRDG = (FBD, NML)\r\nMCP = (DLC, TGK)\r\nNMD = (XFR, GRK)\r\nMVK = (TRJ, RNM)\r\nJKF = (TFX, KHJ)\r\nXFR = (SMG, JNQ)\r\nNGM = (XPX, JLX)\r\nMFD = (GVL, MBR)\r\nRNT = (CDR, BCL)\r\nVVX = (XMJ, XMJ)\r\nGNC = (HST, GJR)\r\nCRF = (PBK, GJM)\r\nJKK = (GCQ, SGC)\r\nGBH = (QDR, RFF)\r\nFJG = (XMQ, KSN)\r\nGDV = (GQN, GXH)\r\nXLB = (FMN, JVN)\r\nKNV = (JBD, SVX)\r\nPXX = (HHG, TTQ)\r\nTDJ = (MFD, QJT)\r\nQLG = (PJN, VFS)\r\nNRN = (HBG, FRX)\r\nSHM = (GRK, XFR)\r\nFHV = (HXX, NQV)\r\nQFH = (GNC, CHX)\r\nPCM = (QLQ, MPH)\r\nVLX = (QMR, PBJ)\r\nRPP = (HRT, RBK)\r\nJXR = (SJK, PTL)\r\nLPQ = (QDR, RFF)\r\nBFR = (STC, PJT)\r\nXTT = (CBC, DSH)\r\nHVF = (VTD, KDC)\r\nJFJ = (FCP, BHF)\r\nLVQ = (PRG, MQP)\r\nJFD = (RBH, DFJ)\r\nHFM = (TPJ, JGX)\r\nBSV = (XQR, PMH)\r\nJLC = (GGR, TFM)\r\nNSQ = (FHV, SCB)\r\nNCP = (VHB, MCP)\r\nJKB = (LDB, TLR)\r\nBLX = (PDJ, GBX)\r\nSVP = (BQJ, BFJ)\r\nVSP = (CHX, GNC)\r\nSPH = (FJB, FQN)\r\nRPS = (VNF, BXD)\r\nQMR = (TKD, XLJ)\r\nQMJ = (MXS, PGH)\r\nJNB = (LGL, SRX)\r\nRGM = (JTP, NTL)\r\nGHK = (JPD, RLK)\r\nTFX = (NJG, NJG)\r\nNBQ = (JKP, NLS)\r\nNTX = (VFS, PJN)\r\nQTS = (RQV, JMD)\r\nLMN = (DSS, PBL)\r\nCLK = (SRM, KCV)\r\nMPD = (RMD, DRB)\r\nPDS = (DDS, MLV)\r\nNNX = (PRG, MQP)\r\nBST = (DRB, RMD)\r\nDSG = (SGV, DVB)\r\nKDC = (QVL, KLC)\r\nVKX = (PSN, DSC)\r\nLJM = (DBB, QXN)\r\nVFV = (SHC, QGJ)\r\nFXR = (RJN, RXD)\r\nHGR = (HPS, MNQ)\r\nBMN = (CCR, RPM)\r\nCRH = (FSC, HTX)\r\nQRV = (BBX, FFJ)\r\nCKK = (VTD, KDC)\r\nSDP = (RNT, RPN)\r\nXLJ = (JTX, QRN)\r\nBSL = (PFL, GLN)\r\nGJD = (FHV, SCB)\r\nVNH = (DCJ, CXG)\r\nBCB = (MXJ, LVR)\r\nNBF = (MPH, QLQ)\r\nMCK = (DVQ, FFT)\r\nRFJ = (HFM, JFK)\r\nBBD = (LJM, NXN)\r\nFMN = (SPR, DMJ)\r\nJXK = (GPK, VQP)\r\nSLL = (MHT, CDG)\r\nTRR = (GNM, CSC)\r\nMJC = (KXR, MCK)\r\nMHT = (FBC, TJF)\r\nTSF = (HDH, RGM)\r\nFLG = (FQL, XQD)\r\nMGX = (SLL, FQH)\r\nRGR = (NMN, PXX)\r\nRDA = (BVG, DJM)\r\nVXX = (DHD, DLQ)\r\nDXT = (BNV, TJG)\r\nLCL = (DHV, NHN)\r\nCKB = (FNN, FKT)\r\nKNH = (LVR, MXJ)\r\nGSQ = (PGR, NDC)\r\nCFM = (DPB, SHQ)\r\nHDH = (JTP, NTL)\r\nNSF = (VFV, QDN)\r\nHSF = (KSJ, KBM)\r\nGSR = (VLX, LBB)\r\nGCT = (RQX, SJD)\r\nRBN = (XDT, KNF)\r\nXNF = (JNK, CKJ)\r\nTCF = (RBK, HRT)\r\nDPA = (MDS, SHG)\r\nQTG = (JMT, DXT)\r\nRGT = (SBP, BSZ)\r\nXCX = (SFD, LGN)\r\nKSJ = (KDR, GKG)\r\nGQN = (QGX, LVK)\r\nMDM = (PJT, STC)\r\nKKZ = (MKM, QXP)\r\nMQC = (JQL, TML)\r\nVFS = (FDL, BQC)\r\nTJX = (JRJ, HQB)\r\nBSF = (MTT, JFP)\r\nVMD = (PQH, VHC)\r\nJTX = (HBT, MTH)\r\nMCH = (FMN, JVN)\r\nVBK = (MSJ, NBQ)\r\nTBP = (GBH, LPQ)\r\nTVX = (VQP, GPK)\r\nNQN = (SVP, PGB)\r\nSMG = (XLC, NVB)\r\nSHD = (BCB, KNH)\r\nJLF = (SQX, GJC)\r\nGSF = (QTS, NHG)\r\nBDN = (PNX, RGP)\r\nGRK = (SMG, JNQ)\r\nPLV = (TLB, TLB)\r\nSQS = (HTJ, VRH)\r\nPDH = (FXM, RJB)\r\nVGP = (LLL, MNN)\r\nJRQ = (TVT, BLX)\r\nCLX = (PCP, FGB)\r\nPMF = (JDC, RJK)\r\nJRJ = (BRL, MXK)\r\nXMQ = (PPV, HFF)\r\nBVT = (RQT, JKB)\r\nFJT = (BXH, GSQ)\r\nFRT = (TNC, PXR)\r\nQVL = (XLB, MCH)\r\nTNM = (BFK, PBC)\r\nXPX = (BDS, TMM)\r\nXCN = (SHH, BSR)\r\nPKT = (FBD, NML)\r\nTLB = (LKT, LKT)\r\nTFG = (RMV, JLV)\r\nSRN = (MDS, SHG)\r\nFRC = (BHF, FCP)\r\nGGR = (RTC, DKJ)\r\nKFH = (JXK, TVX)\r\nJNQ = (XLC, NVB)\r\nMTF = (RGC, THM)\r\nSTT = (RDJ, SMN)\r\nCPL = (XPX, JLX)\r\nFGB = (XPP, QQR)\r\nDLC = (RPP, TCF)\r\nDJM = (QXH, BSQ)\r\nMBH = (SGS, LBJ)\r\nVBD = (RMX, PCX)\r\nCXG = (TRP, CDJ)\r\nNGV = (VMD, BQX)\r\nGQB = (DRN, NXS)\r\nFHR = (HTX, FSC)\r\nDDL = (FQL, XQD)\r\nFBC = (JNP, GQB)\r\nDKJ = (TPH, FJT)\r\nRQB = (GQN, GXH)\r\nLPM = (RDD, MRD)\r\nBKJ = (GCT, TNX)\r\nGMS = (PDH, VHH)\r\nHTM = (JXK, TVX)\r\nPPQ = (CBC, DSH)\r\nMBR = (RQS, PCG)\r\nPJT = (FGJ, QGS)\r\nPQH = (RBN, HBP)\r\nCBT = (RXH, RXH)\r\nCHX = (HST, GJR)\r\nBQC = (JCT, TRR)\r\nNJK = (JMJ, CTD)\r\nQVX = (VRH, HTJ)\r\nKKM = (FTX, CCB)\r\nNXN = (DBB, QXN)\r\nJQL = (GPV, PVN)\r\nMFR = (QXP, MKM)\r\nVML = (HGR, DHP)\r\nPCJ = (THP, RLV)\r\nXRQ = (BVP, NTH)\r\nPXK = (PBD, BJK)\r\nHCX = (HFS, HSF)\r\nQJT = (MBR, GVL)\r\nRLT = (BTX, QKH)\r\nDKG = (QBQ, MPL)\r\nCQP = (TSF, MVT)\r\nHFF = (VBD, SNX)\r\nKNF = (BKJ, PPJ)\r\nFFT = (JFJ, FRC)\r\nDDS = (PGK, DSG)\r\nPFL = (SGB, SFQ)\r\nRXS = (CPC, NQN)\r\nXSV = (XCN, LPT)\r\nMNQ = (VXV, RFQ)\r\nPVN = (SRJ, FNQ)\r\nVNF = (KFH, HTM)\r\nHPQ = (HVF, CKK)\r\nPGK = (DVB, SGV)\r\nVHC = (HBP, RBN)\r\nGBX = (SRN, RXZ)\r\nSGV = (CBK, PGV)\r\nTVV = (QLG, NTX)\r\nKNT = (RPN, RNT)\r\nTXB = (NSF, QJM)\r\nPCP = (XPP, QQR)\r\nPCG = (BDV, VXX)\r\nMQF = (LSC, JTB)\r\nQJN = (CKB, QSX)\r\nQXH = (SVD, XSD)\r\nLCT = (PCJ, GQH)\r\nGKG = (HDN, HJJ)\r\nTKD = (JTX, QRN)\r\nKBQ = (XCN, LPT)\r\nKSM = (VKX, BGL)\r\nMQQ = (NQP, NVQ)\r\nVFF = (HFS, HSF)\r\nSSX = (TVT, TVT)\r\nDSS = (VVX, VVX)\r\nQDR = (SPH, BXM)\r\nPGR = (RGK, RGK)\r\nRML = (QRV, XXD)\r\nXDR = (JNS, FXR)\r\nDVB = (PGV, CBK)\r\nTSX = (QBX, DLJ)\r\nQBQ = (TJR, JSJ)\r\nBBX = (LJF, BSV)\r\nPTL = (DQP, LMN)\r\nPBC = (BBD, SKJ)\r\nVHB = (DLC, TGK)\r\nXJP = (BCB, KNH)\r\nSTC = (QGS, FGJ)\r\nFNQ = (PXK, GDL)\r\nMXJ = (LHK, BBB)\r\nJNP = (NXS, DRN)\r\nSGS = (TBP, VNK)\r\nRFQ = (SHM, NMD)\r\nMLV = (DSG, PGK)\r\nCDR = (VBK, JHN)\r\nCTD = (DCX, BNG)\r\nFRD = (FJX, FJX)\r\nGCQ = (FCH, JLC)\r\nNXS = (KGL, LTN)\r\nJBQ = (SBC, XFF)\r\nNLD = (DKM, TDJ)\r\nVTG = (RBL, RPS)\r\nJJG = (GSR, PVF)\r\nDKM = (QJT, MFD)\r\nRDJ = (LFN, FVJ)\r\nKTJ = (RPM, CCR)\r\nGSG = (FRT, MVG)\r\nMTL = (JLF, MTS)\r\nPNP = (RPV, VML)\r\nTTG = (MBH, GJX)\r\nLSC = (VDP, BSL)\r\nTHR = (DLJ, QBX)\r\nNQV = (BVT, XQK)\r\nLBB = (PBJ, QMR)\r\nNQQ = (KTJ, BMN)\r\nDMJ = (XJP, SHD)\r\nDSC = (XJS, NRN)\r\nRXD = (GMS, XPD)\r\nKBM = (GKG, KDR)\r\nLLP = (LLL, MNN)\r\nHNM = (VMD, BQX)\r\nVNG = (VKH, SCV)\r\nXDG = (GKF, CTZ)\r\nPNX = (MFM, JJP)\r\nPBK = (RHJ, NLD)\r\nBVR = (CNF, HCQ)\r\nDHV = (VCC, RXL)\r\nTGK = (RPP, TCF)\r\nRDD = (NJK, BTB)\r\nNMN = (HHG, TTQ)\r\nHJF = (HPJ, SFK)\r\nBDV = (DLQ, DHD)\r\nTVT = (PDJ, PDJ)\r\nBGH = (TRQ, MLP)\r\nFVJ = (RRL, XNF)\r\nDBB = (KKM, CGV)";
            string demo1 = "RL\r\n\r\nAAA = (BBB, CCC)\r\nBBB = (DDD, EEE)\r\nCCC = (ZZZ, GGG)\r\nDDD = (DDD, DDD)\r\nEEE = (EEE, EEE)\r\nGGG = (GGG, GGG)\r\nZZZ = (ZZZ, ZZZ)";
            string demo2 = "LLR\r\n\r\nAAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)";
            string demo3 = "LR\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22Z)\r\n22Z = (22B, 22B)\r\nXXX = (XXX, XXX)";
            string demo4 = "LRRRL\r\n\r\n11A = (11B, XXX)\r\n11B = (XXX, 11Z)\r\n11Z = (11B, XXX)\r\n22A = (22B, XXX)\r\n22B = (22C, 22C)\r\n22C = (22Z, 22B)\r\n22Z = (22B, 22B)\r\nXXX = (22A, 11Z)";

            Dictionary<string, string[]> map = new Dictionary<string, string[]>();
            string[] temp = input.Split("\r\n\r\n");

            string directions = temp[0];
            string[] network = temp[1].Split("\r\n");
            int st = directions.Length;

            List<Pointer> pointerList = new List<Pointer>();

            foreach (string line in network)
            {
                string[] split = line.Replace(" =", "").Replace("(", "").Replace(",", "").Replace(")", "").Split(' ');
                map.Add(split[0], new string[] { split[1], split[2] });



                Pointer pointer = pointerList.FirstOrDefault(p => p.Id == split[0]);
                if (pointer is null)
                {
                    pointer = new Pointer();
                    pointer.Id = split[0];
                    pointerList.Add(pointer);
                }
                Pointer tooLeft = pointerList.FirstOrDefault(p => p.Id == split[1]);
                if (tooLeft is null)
                {
                    tooLeft = new Pointer();
                    tooLeft.Id = split[1];
                    pointerList.Add(tooLeft);
                }
                Pointer tooRight = pointerList.FirstOrDefault(p => p.Id == split[2]);
                if (tooRight is null)
                {
                    tooRight = new Pointer();
                    tooRight.Id = split[2];
                    pointerList.Add(tooRight);
                }

                pointer.Left = tooLeft;
                pointer.Right = tooRight;

            }

            List<string> possinions = new List<string>();

            foreach (string key in map.Keys)
            {
                if (key.Last() == 'A')
                {
                    possinions.Add(key);
                }
            }
            // start calculating
            var start = DateTime.Now;

            long count = 0;
            int steps = 0;

            bool found = false;
            bool allEndingInZ;
            do
            {
                allEndingInZ = true;

                for (int i = 0; i < possinions.Count; i++)
                {
                    if (directions[steps] == 'R')
                    {
                        possinions[i] = map[possinions[i]][1];
                    }
                    else possinions[i] = map[possinions[i]][0];

                }

                if (possinions[0].Last() == 'Z')
                {
                    foreach (string possition in possinions)
                    {
                        if (possition.Last() != 'Z')
                        {
                            allEndingInZ = false;
                            break;
                        }

                    }
                    if (allEndingInZ)
                    {
                        found = true;
                    }
                }
                // Console.WriteLine();




                steps++;
                if (steps == directions.Length)
                {
                    count++;
                    steps = 0;

                    if (count % 12000 == 0)
                    {
                        //Console.WriteLine(DateTime.Now.Ticks - start.Ticks + "\t- " + steps + (count * directions.Length));
                        break;
                        // count 12.000 IN:
                        // 12133370
                        //  8356016

                    }
                }

            } while (!found);



            Console.WriteLine(DateTime.Now.Ticks - start.Ticks);
            Console.WriteLine(steps + count * directions.Length);
        }
        public void Part1()
        {
            string input = "LRLRLLRRLLRRLRRLRRRLLRLRLRLRLRRLRRRLRLRRLRLLRRLLRLRRLRLRRLLRRRLRLRLRRRLRLLRRRLLLLLLRRRLRRLLLRRLRLRRLRRLRLRRLRRLLRRLRRRLRRRLLRLRLLLRRLLLRRLLRRLRLLRRRLRRRLRRRLRLRRLRRLLLRRRLRRLLRRLRRRLRLRLRRLRRLRRRLRRRLRLLLLRRRLRLRRRLRRRLLRLRRLRRLLRLLLRRLRLRRLRRRLRRRLRRRLLRRRLRLLRRRLRRRLRRRLRRRLRRLRRRLLRRLLRLRLRRRLRRRLRLRRRR\r\n\r\nLFM = (PCJ, GQH)\r\nTHP = (SPP, MKB)\r\nPBL = (VVX, JMM)\r\nDSR = (BST, MPD)\r\nQKF = (DSR, KGX)\r\nAAA = (SLH, CVN)\r\nDSH = (DVN, VXT)\r\nVTK = (NSF, QJM)\r\nQQR = (FNB, CBM)\r\nRQV = (XQQ, NQQ)\r\nCGV = (CCB, FTX)\r\nRXL = (HXQ, HLQ)\r\nMQP = (MSH, TJB)\r\nMPL = (JSJ, TJR)\r\nXQK = (RQT, JKB)\r\nGXT = (JFP, MTT)\r\nLHK = (BVR, MFH)\r\nBXH = (PGR, NDC)\r\nFFV = (MJC, TLD)\r\nTFM = (DKJ, RTC)\r\nMVG = (TNC, PXR)\r\nQXN = (CGV, KKM)\r\nLTN = (MQC, XGD)\r\nNLP = (SQQ, DKG)\r\nQTK = (MBH, GJX)\r\nSSR = (DHV, NHN)\r\nDGJ = (QSX, CKB)\r\nSFD = (GRS, DLD)\r\nHBT = (NVN, HJF)\r\nVKH = (CBT, CBT)\r\nVRH = (FVN, JNB)\r\nHTJ = (JNB, FVN)\r\nBDL = (SQS, QVX)\r\nMMC = (MJC, TLD)\r\nRBL = (VNF, BXD)\r\nRNM = (HJQ, PJF)\r\nCTZ = (NCP, PLT)\r\nJFK = (TPJ, JGX)\r\nHPJ = (MMC, FFV)\r\nRJC = (RBH, DFJ)\r\nDHL = (RJC, JFD)\r\nLVR = (BBB, LHK)\r\nLFD = (GCQ, SGC)\r\nBVG = (BSQ, QXH)\r\nDVN = (MTL, NDG)\r\nXGD = (TML, JQL)\r\nRQS = (VXX, BDV)\r\nCPC = (PGB, SVP)\r\nQLQ = (CLK, CBH)\r\nRXZ = (SHG, MDS)\r\nNTR = (RGP, PNX)\r\nBBB = (MFH, BVR)\r\nRGK = (FRD, FRD)\r\nJLV = (DVV, GSF)\r\nNLS = (VFF, HCX)\r\nRHC = (DKG, SQQ)\r\nNVB = (TTG, QTK)\r\nSLZ = (DJM, BVG)\r\nBFK = (SKJ, BBD)\r\nHXX = (XQK, BVT)\r\nSKS = (SLL, FQH)\r\nSGB = (RLT, RHK)\r\nNPD = (RFJ, DJN)\r\nXSJ = (TSF, MVT)\r\nLLH = (RPV, VML)\r\nNXD = (DJS, FJG)\r\nGJX = (SGS, LBJ)\r\nFBV = (CXG, DCJ)\r\nFRX = (GDV, RQB)\r\nSDC = (RGC, THM)\r\nJCT = (CSC, GNM)\r\nSPS = (MLP, TRQ)\r\nBNG = (PFC, CLX)\r\nSHH = (LPM, VRC)\r\nSGC = (FCH, JLC)\r\nFJB = (MVK, JKT)\r\nDRN = (KGL, LTN)\r\nRJB = (NTR, BDN)\r\nDMC = (JBM, KNV)\r\nHBG = (RQB, GDV)\r\nVRC = (RDD, MRD)\r\nJJP = (GQC, VMP)\r\nPLB = (VKX, BGL)\r\nDVV = (QTS, NHG)\r\nLGL = (SSX, JRQ)\r\nRGC = (DVG, RDQ)\r\nGPK = (DDL, FLG)\r\nNVN = (HPJ, SFK)\r\nDVQ = (JFJ, FRC)\r\nVDP = (PFL, GLN)\r\nCVN = (HNX, QKF)\r\nQXP = (VTG, BDC)\r\nLKT = (SBP, SBP)\r\nQSX = (FNN, FKT)\r\nCSC = (HPQ, SLS)\r\nFNN = (DCV, JKF)\r\nMTH = (NVN, HJF)\r\nTPJ = (HNM, NGV)\r\nNHN = (VCC, RXL)\r\nBHF = (JKK, LFD)\r\nHXQ = (VNH, FBV)\r\nKDR = (HDN, HJJ)\r\nSVD = (VRK, STT)\r\nFGJ = (TNM, CRD)\r\nXFF = (NPD, RXQ)\r\nTNC = (XKT, LRP)\r\nVBM = (GJM, PBK)\r\nXBV = (DGJ, QJN)\r\nGXH = (LVK, QGX)\r\nSLH = (HNX, QKF)\r\nZZZ = (CVN, SLH)\r\nRTC = (TPH, FJT)\r\nNQP = (MJH, MSP)\r\nXSD = (STT, VRK)\r\nHJJ = (XMV, TJX)\r\nJFP = (XSV, KBQ)\r\nFTD = (NMN, PXX)\r\nNVQ = (MSP, MJH)\r\nSHC = (PTV, XDR)\r\nDCV = (TFX, TFX)\r\nBTX = (JJG, FLL)\r\nRDQ = (DCF, FRH)\r\nMTT = (KBQ, XSV)\r\nDRB = (RML, LGR)\r\nPBD = (VSX, FRS)\r\nHFS = (KBM, KSJ)\r\nSKJ = (NXN, LJM)\r\nMTS = (GJC, SQX)\r\nBRL = (TMJ, JTT)\r\nTTQ = (KFC, DPL)\r\nLQF = (DJS, FJG)\r\nTKG = (JFD, RJC)\r\nPGB = (BFJ, BQJ)\r\nBQX = (VHC, PQH)\r\nMRD = (BTB, NJK)\r\nLJF = (XQR, PMH)\r\nBCL = (VBK, JHN)\r\nBHQ = (VMB, SQF)\r\nBSR = (LPM, VRC)\r\nVNK = (GBH, LPQ)\r\nKHJ = (NJG, QQL)\r\nVMB = (BBK, VXF)\r\nQJM = (QDN, VFV)\r\nKFC = (FSM, PMF)\r\nJVN = (DMJ, SPR)\r\nMVT = (RGM, HDH)\r\nPQB = (BVP, NTH)\r\nQQF = (KJP, BDP)\r\nRGP = (JJP, MFM)\r\nDLD = (VSG, BDL)\r\nSCV = (CBT, LHV)\r\nVTD = (KLC, QVL)\r\nFCH = (GGR, TFM)\r\nGJR = (QMX, CFM)\r\nPMH = (GSG, JSF)\r\nDCJ = (CDJ, TRP)\r\nQJX = (NVQ, NQP)\r\nDJN = (JFK, HFM)\r\nDQP = (DSS, PBL)\r\nXXH = (NTX, QLG)\r\nMXK = (JTT, TMJ)\r\nFDL = (JCT, TRR)\r\nMGA = (PLT, NCP)\r\nHPS = (RFQ, VXV)\r\nSBC = (NPD, RXQ)\r\nXPD = (VHH, PDH)\r\nSRX = (SSX, JRQ)\r\nCKJ = (MQQ, QJX)\r\nFKT = (DCV, JKF)\r\nJKP = (VFF, HCX)\r\nJMN = (XSJ, CQP)\r\nGLN = (SFQ, SGB)\r\nPTV = (JNS, FXR)\r\nFXM = (NTR, BDN)\r\nDJS = (XMQ, KSN)\r\nLVC = (FRD, PNN)\r\nJPD = (PQP, XCX)\r\nGQC = (NSQ, GJD)\r\nSFK = (FFV, MMC)\r\nJBD = (TFG, MSN)\r\nBSZ = (RGR, FTD)\r\nSQX = (XRQ, PQB)\r\nPPV = (VBD, SNX)\r\nJSF = (FRT, MVG)\r\nJMT = (TJG, BNV)\r\nJMJ = (DCX, BNG)\r\nKJP = (QFH, VSP)\r\nVXV = (SHM, NMD)\r\nKLC = (XLB, MCH)\r\nJMD = (XQQ, NQQ)\r\nPJN = (FDL, BQC)\r\nPLT = (MCP, VHB)\r\nBGL = (DSC, PSN)\r\nRXH = (SLH, CVN)\r\nVSG = (QVX, SQS)\r\nBDC = (RPS, RBL)\r\nJMM = (XMJ, XDG)\r\nRHK = (QKH, BTX)\r\nRQX = (KSM, PLB)\r\nFQH = (MHT, CDG)\r\nSRM = (PLV, QGV)\r\nHNX = (DSR, KGX)\r\nJNS = (RJN, RXD)\r\nMLP = (JMN, PCR)\r\nLVK = (JHS, QMJ)\r\nPRG = (TJB, MSH)\r\nVGS = (JXR, JLP)\r\nXQQ = (KTJ, BMN)\r\nDGA = (FTD, RGR)\r\nHTX = (MTG, XBV)\r\nCCB = (TXB, VTK)\r\nRQT = (TLR, LDB)\r\nQMX = (SHQ, DPB)\r\nMDS = (KQD, DMC)\r\nJDC = (LCL, SSR)\r\nNHG = (JMD, RQV)\r\nCBM = (DBH, BHQ)\r\nRKB = (VGP, LLP)\r\nSJD = (PLB, KSM)\r\nCDG = (FBC, TJF)\r\nQGV = (TLB, QVB)\r\nBDS = (SPS, BGH)\r\nDGF = (VKH, VKH)\r\nRLV = (MKB, SPP)\r\nSHG = (KQD, DMC)\r\nKQD = (KNV, JBM)\r\nRMV = (DVV, GSF)\r\nMSH = (XXH, TVV)\r\nFJX = (BVG, DJM)\r\nKCV = (PLV, QGV)\r\nMFH = (HCQ, CNF)\r\nTLD = (MCK, KXR)\r\nSLB = (VGP, LLP)\r\nKSN = (HFF, PPV)\r\nRGV = (BDP, KJP)\r\nCNF = (NBF, PCM)\r\nTJF = (GQB, JNP)\r\nNDG = (MTS, JLF)\r\nVHH = (FXM, RJB)\r\nMPH = (CLK, CBH)\r\nRPM = (NXD, LQF)\r\nJHS = (PGH, MXS)\r\nTRJ = (PJF, HJQ)\r\nRJK = (SSR, LCL)\r\nDPB = (SLB, RKB)\r\nXXD = (FFJ, BBX)\r\nQBX = (CRF, VBM)\r\nRMX = (NGM, CPL)\r\nVXT = (MTL, NDG)\r\nKQN = (QQF, RGV)\r\nSFQ = (RLT, RHK)\r\nQGJ = (XDR, PTV)\r\nMSN = (RMV, JLV)\r\nHCQ = (PCM, NBF)\r\nGKF = (PLT, NCP)\r\nVCC = (HLQ, HXQ)\r\nMSJ = (JKP, NLS)\r\nRFF = (BXM, SPH)\r\nFBD = (DGF, VNG)\r\nGLJ = (MQF, RRT)\r\nQRN = (MTH, HBT)\r\nQGS = (TNM, CRD)\r\nXPP = (FNB, CBM)\r\nQQQ = (GHK, DVD)\r\nRBK = (PPQ, XTT)\r\nHHG = (DPL, KFC)\r\nSBP = (FTD, RGR)\r\nMJH = (MLQ, QTG)\r\nJLX = (BDS, TMM)\r\nDVG = (FRH, DCF)\r\nDFJ = (NSK, PDS)\r\nRHJ = (DKM, TDJ)\r\nFQN = (JKT, MVK)\r\nRMD = (LGR, RML)\r\nJTB = (VDP, BSL)\r\nGJM = (NLD, RHJ)\r\nLGP = (CPC, NQN)\r\nJHN = (NBQ, MSJ)\r\nSQF = (BBK, VXF)\r\nHST = (CFM, QMX)\r\nLBJ = (TBP, VNK)\r\nSNX = (PCX, RMX)\r\nPJF = (MGX, SKS)\r\nRRT = (JTB, LSC)\r\nJTT = (MLM, GLJ)\r\nDLQ = (JBQ, RND)\r\nLGR = (QRV, XXD)\r\nLPT = (BSR, SHH)\r\nHQB = (BRL, MXK)\r\nTRP = (LFM, LCT)\r\nJKT = (RNM, TRJ)\r\nMXS = (GQR, KQN)\r\nMKB = (LVQ, NNX)\r\nNDC = (RGK, LVC)\r\nLFN = (RRL, XNF)\r\nSHQ = (RKB, SLB)\r\nJGX = (NGV, HNM)\r\nRPN = (BCL, CDR)\r\nJSJ = (CRH, FHR)\r\nFRH = (THR, TSX)\r\nBNV = (RXS, LGP)\r\nFLL = (GSR, PVF)\r\nDNS = (JLP, JXR)\r\nHDN = (TJX, XMV)\r\nHJQ = (SKS, MGX)\r\nTNX = (SJD, RQX)\r\nXQD = (BFR, MDM)\r\nGNM = (HPQ, SLS)\r\nNML = (DGF, VNG)\r\nBXM = (FJB, FQN)\r\nMSP = (QTG, MLQ)\r\nPBJ = (XLJ, TKD)\r\nMNN = (DNS, VGS)\r\nRBH = (PDS, NSK)\r\nBFJ = (KNT, SDP)\r\nCRD = (PBC, BFK)\r\nTJB = (XXH, TVV)\r\nPDJ = (SRN, SRN)\r\nXJS = (HBG, FRX)\r\nBBK = (LLH, PNP)\r\nQQL = (MFR, KKZ)\r\nFVN = (LGL, SRX)\r\nLRP = (GXT, BSF)\r\nSVX = (MSN, TFG)\r\nPFC = (PCP, FGB)\r\nXMJ = (GKF, GKF)\r\nLLL = (DNS, VGS)\r\nVSX = (TKG, DHL)\r\nRND = (SBC, XFF)\r\nMLQ = (DXT, JMT)\r\nXLC = (TTG, QTK)\r\nTJG = (RXS, LGP)\r\nDPL = (PMF, FSM)\r\nPCR = (CQP, XSJ)\r\nBSQ = (XSD, SVD)\r\nDHP = (HPS, MNQ)\r\nSCB = (HXX, NQV)\r\nFFJ = (LJF, BSV)\r\nFTX = (VTK, TXB)\r\nTRQ = (PCR, JMN)\r\nGDL = (PBD, BJK)\r\nMLM = (RRT, MQF)\r\nTLA = (QXP, MKM)\r\nSMN = (LFN, FVJ)\r\nRRL = (CKJ, JNK)\r\nBDP = (VSP, QFH)\r\nCBC = (DVN, VXT)\r\nJLP = (PTL, SJK)\r\nFRS = (TKG, DHL)\r\nSQQ = (MPL, QBQ)\r\nDVD = (RLK, JPD)\r\nPQP = (LGN, SFD)\r\nFSM = (JDC, RJK)\r\nPSN = (XJS, NRN)\r\nQDN = (SHC, QGJ)\r\nRJN = (XPD, GMS)\r\nHRT = (PPQ, XTT)\r\nCBH = (SRM, KCV)\r\nFSC = (XBV, MTG)\r\nDCX = (CLX, PFC)\r\nXQR = (GSG, JSF)\r\nHBP = (XDT, KNF)\r\nBQJ = (KNT, SDP)\r\nCDJ = (LFM, LCT)\r\nJNK = (MQQ, QJX)\r\nBVP = (MTF, SDC)\r\nTLR = (RHC, NLP)\r\nSJK = (DQP, LMN)\r\nNJG = (MFR, MFR)\r\nRLK = (XCX, PQP)\r\nTPH = (BXH, GSQ)\r\nNSK = (DDS, MLV)\r\nHLQ = (FBV, VNH)\r\nJTP = (FSN, QQQ)\r\nPGH = (KQN, GQR)\r\nSRJ = (PXK, GDL)\r\nTJR = (FHR, CRH)\r\nXDT = (BKJ, PPJ)\r\nGQH = (RLV, THP)\r\nGRS = (BDL, VSG)\r\nDLJ = (CRF, VBM)\r\nVMP = (GJD, NSQ)\r\nMKM = (VTG, BDC)\r\nPVF = (VLX, LBB)\r\nGPV = (SRJ, FNQ)\r\nNTL = (FSN, QQQ)\r\nFQL = (BFR, MDM)\r\nTMJ = (MLM, GLJ)\r\nXKT = (GXT, BSF)\r\nPCX = (NGM, CPL)\r\nXMV = (HQB, JRJ)\r\nQKH = (FLL, JJG)\r\nVQP = (FLG, DDL)\r\nSLS = (CKK, HVF)\r\nTHM = (RDQ, DVG)\r\nPPJ = (GCT, TNX)\r\nTMM = (BGH, SPS)\r\nGVL = (PCG, RQS)\r\nDCF = (TSX, THR)\r\nBJK = (FRS, VSX)\r\nSPP = (NNX, LVQ)\r\nQGX = (QMJ, JHS)\r\nRPV = (HGR, DHP)\r\nMTG = (DGJ, QJN)\r\nKGL = (XGD, MQC)\r\nDHD = (RND, JBQ)\r\nBXD = (KFH, HTM)\r\nKGX = (MPD, BST)\r\nQVB = (LKT, RGT)\r\nCBK = (RDG, PKT)\r\nBTB = (JMJ, CTD)\r\nFSN = (DVD, GHK)\r\nKXR = (FFT, DVQ)\r\nTML = (GPV, PVN)\r\nVXF = (PNP, LLH)\r\nDBH = (SQF, VMB)\r\nFCP = (JKK, LFD)\r\nRXQ = (DJN, RFJ)\r\nNTH = (SDC, MTF)\r\nJBM = (SVX, JBD)\r\nPNN = (FJX, SLZ)\r\nGQR = (QQF, RGV)\r\nPXR = (LRP, XKT)\r\nVRK = (RDJ, SMN)\r\nLDB = (RHC, NLP)\r\nLHV = (RXH, ZZZ)\r\nFNB = (DBH, BHQ)\r\nMFM = (VMP, GQC)\r\nPGV = (PKT, RDG)\r\nSPR = (XJP, SHD)\r\nCCR = (LQF, NXD)\r\nGJC = (XRQ, PQB)\r\nLGN = (GRS, DLD)\r\nRDG = (FBD, NML)\r\nMCP = (DLC, TGK)\r\nNMD = (XFR, GRK)\r\nMVK = (TRJ, RNM)\r\nJKF = (TFX, KHJ)\r\nXFR = (SMG, JNQ)\r\nNGM = (XPX, JLX)\r\nMFD = (GVL, MBR)\r\nRNT = (CDR, BCL)\r\nVVX = (XMJ, XMJ)\r\nGNC = (HST, GJR)\r\nCRF = (PBK, GJM)\r\nJKK = (GCQ, SGC)\r\nGBH = (QDR, RFF)\r\nFJG = (XMQ, KSN)\r\nGDV = (GQN, GXH)\r\nXLB = (FMN, JVN)\r\nKNV = (JBD, SVX)\r\nPXX = (HHG, TTQ)\r\nTDJ = (MFD, QJT)\r\nQLG = (PJN, VFS)\r\nNRN = (HBG, FRX)\r\nSHM = (GRK, XFR)\r\nFHV = (HXX, NQV)\r\nQFH = (GNC, CHX)\r\nPCM = (QLQ, MPH)\r\nVLX = (QMR, PBJ)\r\nRPP = (HRT, RBK)\r\nJXR = (SJK, PTL)\r\nLPQ = (QDR, RFF)\r\nBFR = (STC, PJT)\r\nXTT = (CBC, DSH)\r\nHVF = (VTD, KDC)\r\nJFJ = (FCP, BHF)\r\nLVQ = (PRG, MQP)\r\nJFD = (RBH, DFJ)\r\nHFM = (TPJ, JGX)\r\nBSV = (XQR, PMH)\r\nJLC = (GGR, TFM)\r\nNSQ = (FHV, SCB)\r\nNCP = (VHB, MCP)\r\nJKB = (LDB, TLR)\r\nBLX = (PDJ, GBX)\r\nSVP = (BQJ, BFJ)\r\nVSP = (CHX, GNC)\r\nSPH = (FJB, FQN)\r\nRPS = (VNF, BXD)\r\nQMR = (TKD, XLJ)\r\nQMJ = (MXS, PGH)\r\nJNB = (LGL, SRX)\r\nRGM = (JTP, NTL)\r\nGHK = (JPD, RLK)\r\nTFX = (NJG, NJG)\r\nNBQ = (JKP, NLS)\r\nNTX = (VFS, PJN)\r\nQTS = (RQV, JMD)\r\nLMN = (DSS, PBL)\r\nCLK = (SRM, KCV)\r\nMPD = (RMD, DRB)\r\nPDS = (DDS, MLV)\r\nNNX = (PRG, MQP)\r\nBST = (DRB, RMD)\r\nDSG = (SGV, DVB)\r\nKDC = (QVL, KLC)\r\nVKX = (PSN, DSC)\r\nLJM = (DBB, QXN)\r\nVFV = (SHC, QGJ)\r\nFXR = (RJN, RXD)\r\nHGR = (HPS, MNQ)\r\nBMN = (CCR, RPM)\r\nCRH = (FSC, HTX)\r\nQRV = (BBX, FFJ)\r\nCKK = (VTD, KDC)\r\nSDP = (RNT, RPN)\r\nXLJ = (JTX, QRN)\r\nBSL = (PFL, GLN)\r\nGJD = (FHV, SCB)\r\nVNH = (DCJ, CXG)\r\nBCB = (MXJ, LVR)\r\nNBF = (MPH, QLQ)\r\nMCK = (DVQ, FFT)\r\nRFJ = (HFM, JFK)\r\nBBD = (LJM, NXN)\r\nFMN = (SPR, DMJ)\r\nJXK = (GPK, VQP)\r\nSLL = (MHT, CDG)\r\nTRR = (GNM, CSC)\r\nMJC = (KXR, MCK)\r\nMHT = (FBC, TJF)\r\nTSF = (HDH, RGM)\r\nFLG = (FQL, XQD)\r\nMGX = (SLL, FQH)\r\nRGR = (NMN, PXX)\r\nRDA = (BVG, DJM)\r\nVXX = (DHD, DLQ)\r\nDXT = (BNV, TJG)\r\nLCL = (DHV, NHN)\r\nCKB = (FNN, FKT)\r\nKNH = (LVR, MXJ)\r\nGSQ = (PGR, NDC)\r\nCFM = (DPB, SHQ)\r\nHDH = (JTP, NTL)\r\nNSF = (VFV, QDN)\r\nHSF = (KSJ, KBM)\r\nGSR = (VLX, LBB)\r\nGCT = (RQX, SJD)\r\nRBN = (XDT, KNF)\r\nXNF = (JNK, CKJ)\r\nTCF = (RBK, HRT)\r\nDPA = (MDS, SHG)\r\nQTG = (JMT, DXT)\r\nRGT = (SBP, BSZ)\r\nXCX = (SFD, LGN)\r\nKSJ = (KDR, GKG)\r\nGQN = (QGX, LVK)\r\nMDM = (PJT, STC)\r\nKKZ = (MKM, QXP)\r\nMQC = (JQL, TML)\r\nVFS = (FDL, BQC)\r\nTJX = (JRJ, HQB)\r\nBSF = (MTT, JFP)\r\nVMD = (PQH, VHC)\r\nJTX = (HBT, MTH)\r\nMCH = (FMN, JVN)\r\nVBK = (MSJ, NBQ)\r\nTBP = (GBH, LPQ)\r\nTVX = (VQP, GPK)\r\nNQN = (SVP, PGB)\r\nSMG = (XLC, NVB)\r\nSHD = (BCB, KNH)\r\nJLF = (SQX, GJC)\r\nGSF = (QTS, NHG)\r\nBDN = (PNX, RGP)\r\nGRK = (SMG, JNQ)\r\nPLV = (TLB, TLB)\r\nSQS = (HTJ, VRH)\r\nPDH = (FXM, RJB)\r\nVGP = (LLL, MNN)\r\nJRQ = (TVT, BLX)\r\nCLX = (PCP, FGB)\r\nPMF = (JDC, RJK)\r\nJRJ = (BRL, MXK)\r\nXMQ = (PPV, HFF)\r\nBVT = (RQT, JKB)\r\nFJT = (BXH, GSQ)\r\nFRT = (TNC, PXR)\r\nQVL = (XLB, MCH)\r\nTNM = (BFK, PBC)\r\nXPX = (BDS, TMM)\r\nXCN = (SHH, BSR)\r\nPKT = (FBD, NML)\r\nTLB = (LKT, LKT)\r\nTFG = (RMV, JLV)\r\nSRN = (MDS, SHG)\r\nFRC = (BHF, FCP)\r\nGGR = (RTC, DKJ)\r\nKFH = (JXK, TVX)\r\nJNQ = (XLC, NVB)\r\nMTF = (RGC, THM)\r\nSTT = (RDJ, SMN)\r\nCPL = (XPX, JLX)\r\nFGB = (XPP, QQR)\r\nDLC = (RPP, TCF)\r\nDJM = (QXH, BSQ)\r\nMBH = (SGS, LBJ)\r\nVBD = (RMX, PCX)\r\nCXG = (TRP, CDJ)\r\nNGV = (VMD, BQX)\r\nGQB = (DRN, NXS)\r\nFHR = (HTX, FSC)\r\nDDL = (FQL, XQD)\r\nFBC = (JNP, GQB)\r\nDKJ = (TPH, FJT)\r\nRQB = (GQN, GXH)\r\nLPM = (RDD, MRD)\r\nBKJ = (GCT, TNX)\r\nGMS = (PDH, VHH)\r\nHTM = (JXK, TVX)\r\nPPQ = (CBC, DSH)\r\nMBR = (RQS, PCG)\r\nPJT = (FGJ, QGS)\r\nPQH = (RBN, HBP)\r\nCBT = (RXH, RXH)\r\nCHX = (HST, GJR)\r\nBQC = (JCT, TRR)\r\nNJK = (JMJ, CTD)\r\nQVX = (VRH, HTJ)\r\nKKM = (FTX, CCB)\r\nNXN = (DBB, QXN)\r\nJQL = (GPV, PVN)\r\nMFR = (QXP, MKM)\r\nVML = (HGR, DHP)\r\nPCJ = (THP, RLV)\r\nXRQ = (BVP, NTH)\r\nPXK = (PBD, BJK)\r\nHCX = (HFS, HSF)\r\nQJT = (MBR, GVL)\r\nRLT = (BTX, QKH)\r\nDKG = (QBQ, MPL)\r\nCQP = (TSF, MVT)\r\nHFF = (VBD, SNX)\r\nKNF = (BKJ, PPJ)\r\nFFT = (JFJ, FRC)\r\nDDS = (PGK, DSG)\r\nPFL = (SGB, SFQ)\r\nRXS = (CPC, NQN)\r\nXSV = (XCN, LPT)\r\nMNQ = (VXV, RFQ)\r\nPVN = (SRJ, FNQ)\r\nVNF = (KFH, HTM)\r\nHPQ = (HVF, CKK)\r\nPGK = (DVB, SGV)\r\nVHC = (HBP, RBN)\r\nGBX = (SRN, RXZ)\r\nSGV = (CBK, PGV)\r\nTVV = (QLG, NTX)\r\nKNT = (RPN, RNT)\r\nTXB = (NSF, QJM)\r\nPCP = (XPP, QQR)\r\nPCG = (BDV, VXX)\r\nMQF = (LSC, JTB)\r\nQJN = (CKB, QSX)\r\nQXH = (SVD, XSD)\r\nLCT = (PCJ, GQH)\r\nGKG = (HDN, HJJ)\r\nTKD = (JTX, QRN)\r\nKBQ = (XCN, LPT)\r\nKSM = (VKX, BGL)\r\nMQQ = (NQP, NVQ)\r\nVFF = (HFS, HSF)\r\nSSX = (TVT, TVT)\r\nDSS = (VVX, VVX)\r\nQDR = (SPH, BXM)\r\nPGR = (RGK, RGK)\r\nRML = (QRV, XXD)\r\nXDR = (JNS, FXR)\r\nDVB = (PGV, CBK)\r\nTSX = (QBX, DLJ)\r\nQBQ = (TJR, JSJ)\r\nBBX = (LJF, BSV)\r\nPTL = (DQP, LMN)\r\nPBC = (BBD, SKJ)\r\nVHB = (DLC, TGK)\r\nXJP = (BCB, KNH)\r\nSTC = (QGS, FGJ)\r\nFNQ = (PXK, GDL)\r\nMXJ = (LHK, BBB)\r\nJNP = (NXS, DRN)\r\nSGS = (TBP, VNK)\r\nRFQ = (SHM, NMD)\r\nMLV = (DSG, PGK)\r\nCDR = (VBK, JHN)\r\nCTD = (DCX, BNG)\r\nFRD = (FJX, FJX)\r\nGCQ = (FCH, JLC)\r\nNXS = (KGL, LTN)\r\nJBQ = (SBC, XFF)\r\nNLD = (DKM, TDJ)\r\nVTG = (RBL, RPS)\r\nJJG = (GSR, PVF)\r\nDKM = (QJT, MFD)\r\nRDJ = (LFN, FVJ)\r\nKTJ = (RPM, CCR)\r\nGSG = (FRT, MVG)\r\nMTL = (JLF, MTS)\r\nPNP = (RPV, VML)\r\nTTG = (MBH, GJX)\r\nLSC = (VDP, BSL)\r\nTHR = (DLJ, QBX)\r\nNQV = (BVT, XQK)\r\nLBB = (PBJ, QMR)\r\nNQQ = (KTJ, BMN)\r\nDMJ = (XJP, SHD)\r\nDSC = (XJS, NRN)\r\nRXD = (GMS, XPD)\r\nKBM = (GKG, KDR)\r\nLLP = (LLL, MNN)\r\nHNM = (VMD, BQX)\r\nVNG = (VKH, SCV)\r\nXDG = (GKF, CTZ)\r\nPNX = (MFM, JJP)\r\nPBK = (RHJ, NLD)\r\nBVR = (CNF, HCQ)\r\nDHV = (VCC, RXL)\r\nTGK = (RPP, TCF)\r\nRDD = (NJK, BTB)\r\nNMN = (HHG, TTQ)\r\nHJF = (HPJ, SFK)\r\nBDV = (DLQ, DHD)\r\nTVT = (PDJ, PDJ)\r\nBGH = (TRQ, MLP)\r\nFVJ = (RRL, XNF)\r\nDBB = (KKM, CGV)";
            string demo1 = "RL\r\n\r\nAAA = (BBB, CCC)\r\nBBB = (DDD, EEE)\r\nCCC = (ZZZ, GGG)\r\nDDD = (DDD, DDD)\r\nEEE = (EEE, EEE)\r\nGGG = (GGG, GGG)\r\nZZZ = (ZZZ, ZZZ)";
            string demo2 = "LLR\r\n\r\nAAA = (BBB, BBB)\r\nBBB = (AAA, ZZZ)\r\nZZZ = (ZZZ, ZZZ)";

            Dictionary<string, string[]> map = new Dictionary<string, string[]>();
            string[] temp = input.Split("\r\n\r\n");

            string directions = temp[0];
            string[] network = temp[1].Split("\r\n");


            foreach (string line in network)
            {
                string[] split = line.Replace(" =", "").Replace("(", "").Replace(",", "").Replace(")", "").Split(' ');

                map.Add(split[0], new string[] { split[1], split[2] });
            }

            string currentPossinion = "AAA";
            string target = "ZZZ";
            int steps = 0;

            do
            {

                if (directions[steps % directions.Length] == 'R')
                {
                    currentPossinion = map[currentPossinion][1];
                }
                else currentPossinion = map[currentPossinion][0];

                steps++;


            } while (currentPossinion != target);

            Console.WriteLine(steps);

        }
    }
}
