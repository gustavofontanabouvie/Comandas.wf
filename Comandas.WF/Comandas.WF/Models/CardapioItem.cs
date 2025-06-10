using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF.Models
{
    public class CardapioItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }

        public string Titulo { get; set; }

        public string Descricao{ get; set; }

        public double Preco { get; set; }

        public bool PossuiPreparo{ get; set; }

    }
}
