using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class AttackResultDto
    {
        public string AttackerName { get; set; }
        public string OpponentName { get; set; }
        public int AttackerHp { get; set; }
        public int OpponentHp { get; set; }
        public int Damage { get; set; }
    }
}