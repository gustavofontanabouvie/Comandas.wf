using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF.Models
{
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        public int NumeroMesa { get; set; }
        public string NomeCliente { get; set; }
        public bool SituacaoComanda{ get; set; }
        public virtual ICollection<ComandaItens> ComandaItens { get; set; }

    }
}
