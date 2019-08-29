using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDeBusca
{
    class Node
    {
        private Node no_pai = null;
        private Node no_direita = null;
        private Node no_esquerda = null;
        private int Valor;

        public int get_valor() { return Valor; }
        public void set_valor(int v) { Valor = v; }
        public Node get_no_pai() { return no_pai; }
        public void set_no_pai(Node no) { no_pai = no; }
        public Node get_no_direita() { return no_direita; }
        public void set_no_direita(Node no) { no_direita = no; }
        public Node get_no_esquerda() { return no_esquerda; }
        public void set_no_esquerda(Node no) { no_esquerda = no; }
        

    }    
}
