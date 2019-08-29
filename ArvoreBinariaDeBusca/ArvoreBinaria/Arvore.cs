using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Arvore
    {
        private Node raiz = null;
        private int qntInterno = 0;
        private String resultado = "";
        private int PrimeiroValor = 0;

        public int qntde_nos_internos()
        {
            return qntInterno;
        }
        public bool no_externo(Node no)
        {
            return (no.get_no_direita() == null) && (no.get_no_esquerda() == null);
        }
        public Node cria_no_externo(Node NodePai)
        {
            Node no = new Node();
            no.set_no_pai(NodePai);
            return no;
        }
        public void insere(int valor)
        {
            Node no_auxiliar;
            if (qntInterno == 0)
            {
                no_auxiliar = new Node();
                raiz = no_auxiliar;
                PrimeiroValor = no_auxiliar.get_valor();
            }
            else
            {
                no_auxiliar = raiz;
                while (no_externo(no_auxiliar) == false)
                {
                    if (valor > no_auxiliar.get_valor())
                    {
                        no_auxiliar = no_auxiliar.get_no_direita();
                    }
                    else if (valor < no_auxiliar.get_valor())
                    {
                        no_auxiliar = no_auxiliar.get_no_esquerda();
                    }
                    if (no_auxiliar.get_valor() == valor){

                        break;
                    }
                }
            }
            no_auxiliar.set_valor(valor);
            no_auxiliar.set_no_direita(cria_no_externo(no_auxiliar));
            no_auxiliar.set_no_esquerda(cria_no_externo(no_auxiliar));
            qntInterno++;
        }
        public string listagemEmOrdem()
        {
            resultado = "═";
            ApresentaNoEmOrdem(raiz);
            return resultado;
        }
        private void ApresentaNoEmOrdem(Node no)
        {
            if (no_externo(no))
            {
                return;
            }
            
            ApresentaNoEmOrdem(no.get_no_esquerda());
            resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());
            ApresentaNoEmOrdem(no.get_no_direita());
           
        }
        public string listagemPreOrdem()
        {
            resultado = "═";
            ApresentaNoPreOrdem(raiz);
            return resultado;
        }
        private void ApresentaNoPreOrdem(Node no)
        {
            if (no_externo(no))
            {
                return;
            }
            resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());
            ApresentaNoEmOrdem(no.get_no_esquerda());
            ApresentaNoEmOrdem(no.get_no_direita());

        }
        public string listagemPosOrdem()
        {
            resultado = "═";
            ApresentaNoPosOrdem(raiz);
            return resultado;
        }
        private void ApresentaNoPosOrdem(Node no)
        {
            if (no_externo(no))
            {
                return;
            }
            ApresentaNoEmOrdem(no.get_no_esquerda());
            ApresentaNoEmOrdem(no.get_no_direita());
            resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());

        }
    }
}

//   ║   ╣  ╗ ╝ ╚ ╔ ╩ ╦ ╠ ═ ╬ 