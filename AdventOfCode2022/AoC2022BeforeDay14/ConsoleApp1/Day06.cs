using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day06
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1();
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
        public static void Part1()
        {
            string puzzelInput = "plhlsssjsrscspsffmrffwvfvrvvmbbnjnrnrfnndlnlznlznlnccdbbhvbvgvmvzmzvmzmbbrcclsslzslzzsztzftzzhggnjgnjnhnmnqnqqfdfnnrwnwsnwwvgvqqgpptvtrvvfmmzjzmmjssmwsmmhzzvvwzwcwrcrllpbppdgdvvwqvvsnsrnsncnwntnggwqgqhqrqprqrddjvddqsqhshchfffzddswdsshhcnhnqqfjffvlvwvssdqqwrwvrvhrvrzzgwggcjcgclcwchhzvzmzrrjwjqwwvbwwrmmvmpmzpzgpgsghgrrtmmlfmmnzzmpzzvmvjjsqqshqshsqqgtqggpvvrtttwbbhnbnlbnlnhnthtjhjshhrmrjjlclpprmrnrsrwrbwrwwjnwnbwbhbmbggdbgghllcvlvddzbdbdvdwvdvjvqvcvczvcvclvvrggrngrrwcwbcczgghnhznhnttbcbvcvttrrpbrppndppvvvgvtgvvhfvhhttppjmjllznlnldnldlwlnwlnlttgzzcfcggwmgmqgmmshmhqqdfqfpfqppprzrhrnrhnrrtsrrgpgnpngnqnmmrtrvtrrfccszszffvlfvlvssvdvvpggvcvscvvpmpgpqpfqqhttrhhsbhbqhhzggzrgrqrfqffwllggrgqqjzqzzsgglvgllsgllptltblbggvrggctczzllvsvcscrrzjrzzjnnbvvtntpntnvtntcntcnnwsnnnvjnnsccsddcvvgzgwggbnbwnwbwmwttzzsgzzjpzztwztwwhhzggplgplggwwwphpmmhchsccmwmttvjtjftffzbfffjljbbqvvstsggbbqrbqrbrhbbrmbmppvrpphptpggqgddtmdtmdmbbbcdbbgssmzzthhtjjrgjrgrzzchzhttgddjnjrjmjllrcrqqsvsjjjhvvphhgjhgjhjccwmcmjcmjmhmzznmmcbcscddcsssnppsnpnmnqmmtztftqtjtqqgvgvjjfnjffqbqbfqqwfqfcfsfttvccnssjvvpfvpvttvpvccwhwfwlwlclljqqststllgqgzqqfpflpplpssnntstqqpnnsrnsrrsvrsvsrvsrrtztmtptpcpssgnnfvflffscsqszzsppfnftfptfpfnfbbwzbzfbbtggrzrnntztnznhnnlbnbrbdddjhjchhdshhnzhnnsrnrrqwrrdsdlsstdsslqsqdqvqzvqvwqqlmmwzmwzwztzlzczhqfrclvgvnlchrggsrjhntctdbpfdcffwjngdvdrjmgvwvptlvlhvhshqphmrdznqbtchcvrwfrpvwhzmrwlcjwnrsgrqcbsgpwjthstvqzlwjjmqbvhhdfdsmqnmnswmwjtpgjhdpgcnvmlcjwjzrjhmrqmqnrqrmgdnbdgznwhgzncmcbzpntcdflvrbfdzwgpnqjqmrcqpbrzwhwdgtgshhmrwvhnrwslvcswjvdgglfrdvmqdspppwmvfzvdbvpcnhmvgfqwnvjvvzrvttwvbjrbjlllmwtlcltvqmwshnqsdtjrptvqjvdjgzwgzzhcdbwjzhdgsptfrtmmqvhsnsnpgwbncbnnvwmmrrjgfccbzcpcjmqvqsbvjrstzblsrngphwndfdswjnnnfdgpcbslvbjglqqnbbtjljsmdgcslmwlvgwpsqthlmmqfgpgmcvrpvvtzcjdrwcjgrbwthblwpwpbzvjvhzsphmfhfwvsthlfnhhfcmpsnmgrvrntlzpdvqwtrghnslnfhcjwrsvrngqqtwvcsfhbjwmsnmsmgvdhnzjgljtchbtwlfppvbtdclbdjdmwzcntvgfjlcwdplnjwqnzqhnfgcnbrgftqpdmqzrrhglbzzvjcdnbtfnvmsrbjdzhbqmhnsmprgvjzzgvllhqnzgpstqzcnlgsrcwzlhwqvcjlwnnjslmdtwqcpbrntrmrmmtscjwwtzjhghtqvvpldzvhtmspzlnlfgrfhmsndbdgpgvphwwgqhrtlwztgqqsrwnrnqphqfsrtbztqbrgmfbtpjwhhrglhbzmmjptppnfdzlpbqfcbdwzdtqbrvfmtdzdjlnzvqfnzmttpqgzgmrqwmdtmdzrttffpdlgwdhnlrhnnztphvrbzcrlvcpswlngcjhdzqwwwpzdmhhwpnzwgjsdsdbdvpfsrwmwvsggpcqbchwjpgljnbtpvjzbbvgsbsbjmtwtbjtzzsfvrmfvnmcngvvdsvljvjbrlfgstjrhtjplttzhjfbmphvbqdsmwfwspqpcvmgzgjnqlphshlgdwcvtmpwcfgdcbqwpnshfgrfjvlrtqbffwwtbnwtvjlsdgwgfmhlrsmfrjzcwccdzfwwdwhwdsjbllhjsqmnqvngvdmbvbssfjtjfbtngrdwgldcrtpmvrbrmpvwwsfrlnbqsqzfnftpbhslqccnbqwgbdbfpblpmwbgjzmnptnhdjzqjhdrhqbtfhsrdqwlmwzqlsmmslgfzpvtgtsrlszvqrhrzclbqhzzwwfmhrrvsrnsjbdjsqqlsmgdmgbdtmvfjmsbwjqmqrvrhqbchpqrwvlvwpvhjlbdzfjvrwmchccrsrfvhzmpfjqwnrbvqmgwjcbndjdtfgnrzrqwgzhrdvghdrvgtplcrthgchmvwtdrchfwpdszzzhqpmrlzvfdnfnlwghmmwvsscbrdbchhgttsnbzdbqgddqfvcgvqwltnqtcwrmhtftnlwvlglsvvctccnntznsjnmmgqlzmplsdspnjtmzlbvrfzfclnhgjzmvntdwhspqwtpgndspnjqjqwrpwhjhpvjwfptpndnwvcjdwsvdtcrtwpsprgmrspgmcsdgtjbbgsgvcjhrcldlvgvqwqwthplzgwbzmszjfrlnznvgphnqzcwsztvvljlrlzrndbzccstprhntnlmshhclnrsmsvvvsbmpfdjsmspwcqtmlrrdmfzjjjhmsmdfqddzpgtbzbsnhhhpsfrdrdvpvpnjmvnhdrzrqggrpqdcmctvqfrtfmjjqjwgzzbrdfplhzjbnqlmjlcgvmsbpgdlfjmbgqtrvzzdgtlmbqthjrdtlstqtzqvfjvmmstsmtsbnjvstjjvrrjqcbjvhfpslpvjmdznrcnsvlpbpzmslqtpczmvhdwzrhwbwtfvrrmbszvrhwsjrclcscgngwvblbbrqprgshwzhlqgwmpfsmqsvpjbdccdmtnnhqfwvlgjlszmmmdmtmpzwhplzsjztrnwngbvspqqbmghwzgvfjdrblfmtwcvnczsrflmsjmrsvzldmttjwcmnvwcbjfvznhgntnqfbfchcqqshhjldgltqhdlqldlpfjnjvtbvbntzdjzstcqbzdnmsvcdgvjmmvtdfvdplqfndqqlzlspmjgdfbgsvwzqzsvvbbldltbtzwzpqrzfmfzgdbpqnwtrfcgwmlbpzrgscbjvfdwnjzjdfzltsbppnljzrgggplmttpmgwnhdlwfhwzsrcflnrqqzwsbqllwjqlrgwbhvcvqdvjvpbzgnfbbbtccvplzggplbrsbldllwmttwtvltsfljfbbprtvlfshhwdhdgvzfzjttvnphpnjnzsbvfwflfpqwnhvwjdsrtbwsjzqhgfldnssfbbzzqqrwtjvwjschmndgqzjtpsbfhwtmqbtfstrbghgtnldjqtshdnrwzvwddchhvdbsfjnqzfjdpvhvwwjspftgbtgwzdfgzzhpvjpdlrrdfnpftshthwzjzmzdghnfdqcbmjhfdgzrcgrzbrjtmhwbjhcpgjdsmnqzncdlwhqqzqblgdbbdsmrqgbdbmdczvvpnbbjdwrlmrwgnnbbzpcnsjgcmshgzwnjzwjlrdmvmhvjrzphgpczppqvwjthcdphprhhrggjdpzmgtpjjfvpczzrvsssfrrptnzlstrhmbhvzmwjnddshrrtgspbllvqlsptrtvtldsgnjjbwtfmtbjdvmgbptjlzhpttjmvpgnjphswhtdq";
            bool found = false;
            int foundAt = -1;


            char first = puzzelInput[0];
            char secnd = puzzelInput[1];
            char therd = puzzelInput[2];
            char fourt = puzzelInput[3];

            int i = 4;
            while (i < puzzelInput.Length && found == false)
            {



                char newChar = puzzelInput[i];
                //if (newChar != first && newChar != secnd && newChar != therd && newChar != fourt)
                //{
                if (first != therd && secnd != fourt && secnd != therd && first != secnd && therd != fourt && first != fourt)
                {
                    found = true;
                    foundAt = i;
                }

                //}

                first = secnd;
                secnd = therd;
                therd = fourt;
                fourt = newChar;

                i++;
            }

            Console.WriteLine(foundAt);

        }
        public static void Part2()
        {
            string puzzelInput = "plhlsssjsrscspsffmrffwvfvrvvmbbnjnrnrfnndlnlznlznlnccdbbhvbvgvmvzmzvmzmbbrcclsslzslzzsztzftzzhggnjgnjnhnmnqnqqfdfnnrwnwsnwwvgvqqgpptvtrvvfmmzjzmmjssmwsmmhzzvvwzwcwrcrllpbppdgdvvwqvvsnsrnsncnwntnggwqgqhqrqprqrddjvddqsqhshchfffzddswdsshhcnhnqqfjffvlvwvssdqqwrwvrvhrvrzzgwggcjcgclcwchhzvzmzrrjwjqwwvbwwrmmvmpmzpzgpgsghgrrtmmlfmmnzzmpzzvmvjjsqqshqshsqqgtqggpvvrtttwbbhnbnlbnlnhnthtjhjshhrmrjjlclpprmrnrsrwrbwrwwjnwnbwbhbmbggdbgghllcvlvddzbdbdvdwvdvjvqvcvczvcvclvvrggrngrrwcwbcczgghnhznhnttbcbvcvttrrpbrppndppvvvgvtgvvhfvhhttppjmjllznlnldnldlwlnwlnlttgzzcfcggwmgmqgmmshmhqqdfqfpfqppprzrhrnrhnrrtsrrgpgnpngnqnmmrtrvtrrfccszszffvlfvlvssvdvvpggvcvscvvpmpgpqpfqqhttrhhsbhbqhhzggzrgrqrfqffwllggrgqqjzqzzsgglvgllsgllptltblbggvrggctczzllvsvcscrrzjrzzjnnbvvtntpntnvtntcntcnnwsnnnvjnnsccsddcvvgzgwggbnbwnwbwmwttzzsgzzjpzztwztwwhhzggplgplggwwwphpmmhchsccmwmttvjtjftffzbfffjljbbqvvstsggbbqrbqrbrhbbrmbmppvrpphptpggqgddtmdtmdmbbbcdbbgssmzzthhtjjrgjrgrzzchzhttgddjnjrjmjllrcrqqsvsjjjhvvphhgjhgjhjccwmcmjcmjmhmzznmmcbcscddcsssnppsnpnmnqmmtztftqtjtqqgvgvjjfnjffqbqbfqqwfqfcfsfttvccnssjvvpfvpvttvpvccwhwfwlwlclljqqststllgqgzqqfpflpplpssnntstqqpnnsrnsrrsvrsvsrvsrrtztmtptpcpssgnnfvflffscsqszzsppfnftfptfpfnfbbwzbzfbbtggrzrnntztnznhnnlbnbrbdddjhjchhdshhnzhnnsrnrrqwrrdsdlsstdsslqsqdqvqzvqvwqqlmmwzmwzwztzlzczhqfrclvgvnlchrggsrjhntctdbpfdcffwjngdvdrjmgvwvptlvlhvhshqphmrdznqbtchcvrwfrpvwhzmrwlcjwnrsgrqcbsgpwjthstvqzlwjjmqbvhhdfdsmqnmnswmwjtpgjhdpgcnvmlcjwjzrjhmrqmqnrqrmgdnbdgznwhgzncmcbzpntcdflvrbfdzwgpnqjqmrcqpbrzwhwdgtgshhmrwvhnrwslvcswjvdgglfrdvmqdspppwmvfzvdbvpcnhmvgfqwnvjvvzrvttwvbjrbjlllmwtlcltvqmwshnqsdtjrptvqjvdjgzwgzzhcdbwjzhdgsptfrtmmqvhsnsnpgwbncbnnvwmmrrjgfccbzcpcjmqvqsbvjrstzblsrngphwndfdswjnnnfdgpcbslvbjglqqnbbtjljsmdgcslmwlvgwpsqthlmmqfgpgmcvrpvvtzcjdrwcjgrbwthblwpwpbzvjvhzsphmfhfwvsthlfnhhfcmpsnmgrvrntlzpdvqwtrghnslnfhcjwrsvrngqqtwvcsfhbjwmsnmsmgvdhnzjgljtchbtwlfppvbtdclbdjdmwzcntvgfjlcwdplnjwqnzqhnfgcnbrgftqpdmqzrrhglbzzvjcdnbtfnvmsrbjdzhbqmhnsmprgvjzzgvllhqnzgpstqzcnlgsrcwzlhwqvcjlwnnjslmdtwqcpbrntrmrmmtscjwwtzjhghtqvvpldzvhtmspzlnlfgrfhmsndbdgpgvphwwgqhrtlwztgqqsrwnrnqphqfsrtbztqbrgmfbtpjwhhrglhbzmmjptppnfdzlpbqfcbdwzdtqbrvfmtdzdjlnzvqfnzmttpqgzgmrqwmdtmdzrttffpdlgwdhnlrhnnztphvrbzcrlvcpswlngcjhdzqwwwpzdmhhwpnzwgjsdsdbdvpfsrwmwvsggpcqbchwjpgljnbtpvjzbbvgsbsbjmtwtbjtzzsfvrmfvnmcngvvdsvljvjbrlfgstjrhtjplttzhjfbmphvbqdsmwfwspqpcvmgzgjnqlphshlgdwcvtmpwcfgdcbqwpnshfgrfjvlrtqbffwwtbnwtvjlsdgwgfmhlrsmfrjzcwccdzfwwdwhwdsjbllhjsqmnqvngvdmbvbssfjtjfbtngrdwgldcrtpmvrbrmpvwwsfrlnbqsqzfnftpbhslqccnbqwgbdbfpblpmwbgjzmnptnhdjzqjhdrhqbtfhsrdqwlmwzqlsmmslgfzpvtgtsrlszvqrhrzclbqhzzwwfmhrrvsrnsjbdjsqqlsmgdmgbdtmvfjmsbwjqmqrvrhqbchpqrwvlvwpvhjlbdzfjvrwmchccrsrfvhzmpfjqwnrbvqmgwjcbndjdtfgnrzrqwgzhrdvghdrvgtplcrthgchmvwtdrchfwpdszzzhqpmrlzvfdnfnlwghmmwvsscbrdbchhgttsnbzdbqgddqfvcgvqwltnqtcwrmhtftnlwvlglsvvctccnntznsjnmmgqlzmplsdspnjtmzlbvrfzfclnhgjzmvntdwhspqwtpgndspnjqjqwrpwhjhpvjwfptpndnwvcjdwsvdtcrtwpsprgmrspgmcsdgtjbbgsgvcjhrcldlvgvqwqwthplzgwbzmszjfrlnznvgphnqzcwsztvvljlrlzrndbzccstprhntnlmshhclnrsmsvvvsbmpfdjsmspwcqtmlrrdmfzjjjhmsmdfqddzpgtbzbsnhhhpsfrdrdvpvpnjmvnhdrzrqggrpqdcmctvqfrtfmjjqjwgzzbrdfplhzjbnqlmjlcgvmsbpgdlfjmbgqtrvzzdgtlmbqthjrdtlstqtzqvfjvmmstsmtsbnjvstjjvrrjqcbjvhfpslpvjmdznrcnsvlpbpzmslqtpczmvhdwzrhwbwtfvrrmbszvrhwsjrclcscgngwvblbbrqprgshwzhlqgwmpfsmqsvpjbdccdmtnnhqfwvlgjlszmmmdmtmpzwhplzsjztrnwngbvspqqbmghwzgvfjdrblfmtwcvnczsrflmsjmrsvzldmttjwcmnvwcbjfvznhgntnqfbfchcqqshhjldgltqhdlqldlpfjnjvtbvbntzdjzstcqbzdnmsvcdgvjmmvtdfvdplqfndqqlzlspmjgdfbgsvwzqzsvvbbldltbtzwzpqrzfmfzgdbpqnwtrfcgwmlbpzrgscbjvfdwnjzjdfzltsbppnljzrgggplmttpmgwnhdlwfhwzsrcflnrqqzwsbqllwjqlrgwbhvcvqdvjvpbzgnfbbbtccvplzggplbrsbldllwmttwtvltsfljfbbprtvlfshhwdhdgvzfzjttvnphpnjnzsbvfwflfpqwnhvwjdsrtbwsjzqhgfldnssfbbzzqqrwtjvwjschmndgqzjtpsbfhwtmqbtfstrbghgtnldjqtshdnrwzvwddchhvdbsfjnqzfjdpvhvwwjspftgbtgwzdfgzzhpvjpdlrrdfnpftshthwzjzmzdghnfdqcbmjhfdgzrcgrzbrjtmhwbjhcpgjdsmnqzncdlwhqqzqblgdbbdsmrqgbdbmdczvvpnbbjdwrlmrwgnnbbzpcnsjgcmshgzwnjzwjlrdmvmhvjrzphgpczppqvwjthcdphprhhrggjdpzmgtpjjfvpczzrvsssfrrptnzlstrhmbhvzmwjnddshrrtgspbllvqlsptrtvtldsgnjjbwtfmtbjdvmgbptjlzhpttjmvpgnjphswhtdq";


            int foundAt = -1;
            bool found = false;


            int i = 13;

            while (i < puzzelInput.Length && found != true)
            {
                int doubleCount = 0;
                string testing = puzzelInput.Substring(i - 13, 14);

                for (int j = 0; j < testing.Length; j++)
                {

                    if (testing.Substring(j + 1).IndexOf(testing[j]) >= 0)
                    {
                        doubleCount++;
                    }
                }

                i++;

                if (doubleCount == 0)
                {
                    found = true;
                    foundAt = i;
                }

            }
            // not 3715



            Console.WriteLine(foundAt);



        }
    }
}
