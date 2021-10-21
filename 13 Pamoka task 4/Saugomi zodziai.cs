using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_task_4
{
    public class Saugomi_zodziai : Neriboti_string
    {
        public List<string>Zodziu_sarasas;

        public Saugomi_zodziai (List<string> zodziu_sarasas, string mano_zodis) : base(mano_zodis)
        {
            Zodziu_sarasas = zodziu_sarasas;
        }
        public void Zodziu_saugykla ()
        {
            Saugomi_zodziai sarasiukas = new Saugomi_zodziai();

        }
    }
}
