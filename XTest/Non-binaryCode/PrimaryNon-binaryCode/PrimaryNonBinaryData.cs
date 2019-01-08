using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTest.Models;

namespace XTest.CyclicCode.AbramsonaCode
{
    class PrimaryNonBinaryData : IData<Dictionary<string, string>>
    {
        public Dictionary<string, string> Data => throw new NotImplementedException();
        public Dictionary<string, string> CodecData { get; } = new Dictionary<string, string>() {

            {"4,1,viot,На определение сочетания",    "v i o t" },
            {"4,2,onrf,    Сменно-качественный", "on or of no nr nf ro rn rf fo fn fr" },
            {"5,5,vxdon,На определение сочетания",    "vxdon" },
            {"4,2,ndgh,На размещение",  "nb ng nh bn bg bh gn gb gh hn hb hg" },
            {"4,2,abcq,Сменно-качественный", "ab ac aq ba bc bq ca cb cq qa qb qc" },
            {"3,1,xmd,Сменно-качественный", "x m b" },
            {"4,3,poke,На определение сочетания","pok poe pke oke" },
            {"5,3,kdgxs,На размещение", "kdg kdx kds kgd kgx kgs kxd kxg kxs ksd ksg ksx dkg dkx dks dgk dgx dgs dxk dxg dxs dsk dsg dsx gkd gkx gks gdk gdx gds gxk gxd gxs gsk gsd gsx xkd xkg xks xdk xdg xds xgk xgd xgs xsk xsd xsg skd skg skx sdk sdg sdx sgk sgd sgx sxk sxd sxg" },
            {"4,3,tdsb,На все сочетания","ttt ttd tts ttb tdt tdd tds tdb tst tsd tss tsb tbt tbd tbs tbb dtt dtd dts dtb ddt ddd dds ddb dst dsd dss dsb dbt dbd dbs dbb stt std sts stb sdt sdd sds sdb sst ssd sss ssb sbt sbd sbs sbb btt btd bts btb bdt bdd bds bdb bst bsd bss bsb bbt bbd bbs bbb" },
            {"3,1,lhm,На размещение","l h m" },
            {"3,1,kha,Сменно-качественный", "k h a" },
            {"5,3,eumno,На размещение", "eum eun euo emu emn emo enu enm eno eou eom eon uem uen ueo ume umn umo une unm uno uoe uom uon meu men meo mue mun muo mne mnu mno moe mou mon neu nem neo nue num nuo nme nmu nmo noe nou nom oeu oem oen oue oum oun ome omu omn one onu onm" },
            {"5,1,mnyax,На определение сочетания", "m n y a x" },
            {"4,1,bdtw,Сменно-качественный", "b d t w" },
            {"3,2,phz,На определение сочетания", "ph pz hz" },
            {"4,4,ruzm,Сменно-качественный", "ruru rurz rurm ruzr ruzu ruzm rumr rumu rumz rzru rzrz rzrm rzur rzuz rzum rzmr rzmu rzmz rmru rmrz rmrm rmur rmuz rmum rmzr rmzu rmzm urur uruz urum urzr urzu urzm urmr urmu urmz uzru uzrz uzrm uzur uzuz uzum uzmr uzmu uzmz umru umrz umrm umur umuz umum umzr umzu umzm zrur zruz zrum zrzr zrzu zrzm zrmr zrmu zrmz zuru zurz zurm zuzr zuzu zuzm zumr zumu zumz zmru zmrz zmrm zmur zmuz zmum zmzr zmzu zmzm mrur mruz mrum mrzr mrzu mrzm mrmr mrmu mrmz muru murz murm muzr muzu muzm mumr mumu mumz mzru mzrz mzrm mzur mzuz mzum mzmr mzmu mzmz" },
            {"4,4,nglo,На перестановки", "nglo ngol nlgo nlog nogl nolg gnlo gnol glno glon gonl goln lngo lnog lgno lgon long logn ongl onlg ognl ogln olng olgn" },
            {"5,5,pmvzj,На определение сочетания",    "pmvzj" },
            {"4,1,wmcz,На определение сочетания",    "w m c z" },
            {"5,5,htzla,На перестановки", "htzla htzal htlza htlaz htazl htalz hztla hztal hzlta hzlat hzatl hzalt hltza hltaz hlzta hlzat hlatz hlazt hatzl hatlz haztl hazlt haltz halzt thzla thzal thlza thlaz thazl thalz tzhla tzhal tzlha tzlah tzahl tzalh tlhza tlhaz tlzha tlzah tlahz tlazh tahzl tahlz tazhl tazlh talhz talzh zhtla zhtal zhlta zhlat zhatl zhalt zthla zthal ztlha ztlah ztahl ztalh zlhta zlhat zltha zltah zlaht zlath zahtl zahlt zathl zatlh zalht zalth lhtza lhtaz lhzta lhzat lhatz lhazt lthza lthaz ltzha ltzah ltahz ltazh lzhta lzhat lztha lztah lzaht lzath lahtz lahzt lathz latzh lazht lazth ahtzl ahtlz ahztl ahzlt ahltz ahlzt athzl athlz atzhl atzlh atlhz atlzh azhtl azhlt azthl aztlh azlht azlth alhtz alhzt althz altzh alzht alzth" },
            {"4,4,svox,На размещение", "svox svxo sovx soxv sxvo sxov vsox vsxo vosx voxs vxso vxos osvx osxv ovsx ovxs oxsv oxvs xsvo xsov xvso xvos xosv xovs" },
            {"3,2,sgw,На размещение",   "sg sw gs gw ws wg" },
            {"4,1,lihf,На все сочетания",  "l j h f" },
            {"5,5,uqkbp,На перестановки", "uqkbp uqkpb uqbkp uqbpk uqpkb uqpbk ukqbp ukqpb ukbqp ukbpq ukpqb ukpbq ubqkp ubqpk ubkqp ubkpq ubpqk ubpkq upqkb upqbk upkqb upkbq upbqk upbkq qukbp qukpb qubkp qubpk qupkb qupbk qkubp qkupb qkbup qkbpu qkpub qkpbu qbukp qbupk qbkup qbkpu qbpuk qbpku qpukb qpubk qpkub qpkbu qpbuk qpbku kuqbp kuqpb kubqp kubpq kupqb kupbq kqubp kqupb kqbup kqbpu kqpub kqpbu kbuqp kbupq kbqup kbqpu kbpuq kbpqu kpuqb kpubq kpqub kpqbu kpbuq kpbqu buqkp buqpk bukqp bukpq bupqk bupkq bqukp bqupk bqkup bqkpu bqpuk bqpku bkuqp bkupq bkqup bkqpu bkpuq bkpqu bpuqk bpukq bpquk bpqku bpkuq bpkqu puqkb puqbk pukqb pukbq pubqk pubkq pqukb pqubk pqkub pqkbu pqbuk pqbku pkuqb pkubq pkqub pkqbu pkbuq pkbqu pbuqk pbukq pbquk pbqku pbkuq pbkqu" },



        };

        public Dictionary<string, bool> DeCodecData { get; } = new Dictionary<string, bool>()
        {
           {"uh,5,2,muhsy,На определение сочетания",true },
           {"mfamd,5,5,mfadh,На размещение",false },
           {"hp,3,2,hpb,На определение сочетания",false },
           {"e,3,1,cke,Сменно-качественный",true },
           {"hsssk,5,5,sqkch,На перестановки",false },
           {"r,4,1,qzrl,На все сочетания",true },
           {"xlxll,5,5,xelfi,На перестановки",false },
           {"uy,4,2,uyng,Сменно-качественный",true },
           {"yetq,4,4,qtey,На все сочетания",true },
           {"ls,5,2,ljswk,На определение сочетания",true },
           {"dvvv,4,4,ndmv,На перестановки",false},
           {"vvv,3,3,vmy,На размещение",false},
           {"jja,3,3,jxa,Сменно-качественный",false},
           {"vp,4,2,apvd,На размещение",true },
           {"euhhe,5,5,dneuh,На размещение",false},
           {"wsbo,4,4,bwso,На перестановки",true },
           {"xxk,5,3,igbkx,На размещение",false},
           {"www,3,3,lwb,На перестановки",false},
           {"n,4,1,znfx,Сменно-качественный",true },
           {"ynduy,5,5,yudln,На перестановки",false},
           {"ssn,4,3,nshx,Сменно-качественный",false},
           {"pp,4,2,empq,Сменно-качественный",false},
           {"b,4,1,bask,Сменно-качественный",true },
           {"dddy,4,4,dyol,На определение сочетания",false},
           {"hx,3,2,lhx,На размещение",true },
        };
    }
}
