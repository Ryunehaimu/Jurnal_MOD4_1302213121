using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213121
{
    internal class PosisiKarakterGame
    {
        public enum posisi
        {
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }
        public enum Trigger
        {
            Tombol_S,
            Tombol_X,
            Tombol_W,
        }
        public posisi currentStat = posisi.Berdiri;

        public class Transition_1302213121
        {
            public posisi statAwal;
            public posisi statAkhir;
            public Trigger trigger;

            public Transition_1302213121(posisi statAwal, posisi statAkhir, Trigger trigger)
            {
                this.statAwal = statAwal;
                this.statAkhir = statAkhir;
                this.trigger = trigger;
            }
        }

        Transition_1302213121[] transitions = new Transition_1302213121[]
        {
                new Transition_1302213121(posisi.Berdiri, posisi.Terbang, Trigger.Tombol_W),
                new Transition_1302213121(posisi.Terbang, posisi.Berdiri, Trigger.Tombol_S),
                new Transition_1302213121(posisi.Berdiri, posisi.Jongkok, Trigger.Tombol_S),
                new Transition_1302213121(posisi.Jongkok, posisi.Berdiri, Trigger.Tombol_W),
                new Transition_1302213121(posisi.Terbang, posisi.Jongkok, Trigger.Tombol_X),
                new Transition_1302213121(posisi.Jongkok, posisi.Tengkurap, Trigger.Tombol_S),
                new Transition_1302213121(posisi.Tengkurap, posisi.Jongkok, Trigger.Tombol_W),
        };

        private posisi GetNextStat_1302213121(posisi statAwal, Trigger trigger)
        {
            posisi statAkhir = statAwal;
            for (int i = 0; i < transitions.Length; i++)
            {
                Transition_1302213121 update = transitions[i];

                if (statAwal == update.statAwal && trigger == update.trigger)
                {
                    statAkhir = update.statAkhir;
                }
            }
            return statAkhir;
        }

        public void activateTrigger_1302213121(Trigger trigger)
        {
            currentStat = GetNextStat_1302213121(currentStat, trigger);
            Console.WriteLine(currentStat);

            if (currentStat == posisi.Berdiri)
            {
                Console.WriteLine("Posisi Standby");
            }
            else
            {
                Console.WriteLine("Posisi Istirahat");
            }
        }
    }
}
