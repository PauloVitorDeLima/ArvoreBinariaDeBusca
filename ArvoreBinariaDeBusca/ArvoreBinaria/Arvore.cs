using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Arvore
    {
        public Node raiz = null;
        private int qntInterno = 0;
        private String resultado = "";


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
        public void deleta(int valor)
        {
            Node atual = raiz;
            Node pai = raiz;
            Boolean filho_esquerda = true;
            while (atual.get_valor() != valor)
            {
                pai = atual;
                if (valor < atual.get_valor())
                {
                    filho_esquerda = true;
                    atual = atual.get_no_esquerda();
                }
                else
                {
                    filho_esquerda = false;
                    atual = atual.get_no_direita();
                }
                if (atual == null)
                {
                    break;
                }
            }
            if (atual.get_no_esquerda() == null && atual.get_no_direita() == null)
            {
                if (atual == raiz)
                raiz = null;

                else if (filho_esquerda)
                {
                    pai.set_no_esquerda(null);
                }
                else
                {
                    pai.set_no_direita(null);
                }
            }else if (atual.get_no_direita() == null)
            {
                if (atual == raiz)
                {
                    raiz = atual.get_no_esquerda();
                }else if (filho_esquerda)
                {
                    pai.set_no_esquerda(atual.get_no_esquerda());
                }
                else
                {
                    pai.set_no_direita(atual.get_no_direita());
                }
            }
            else if (atual.get_no_esquerda() == null)
            {
                if (atual == raiz)
                {
                    raiz = atual.get_no_direita();
                }else if (filho_esquerda)
                {
                    pai.set_no_esquerda(atual.get_no_direita());
                }
                else
                {
                    pai.set_no_direita(atual.get_no_direita());
                }
            }
            else
            {
                Node sucessor = getSucessor(atual);
                if (atual == raiz)
                {
                    raiz = sucessor;
                }
                else if (filho_esquerda)
                {
                    pai.set_no_esquerda(sucessor);
                }
                else
                {
                    pai.set_no_direita(sucessor);
                }
                sucessor.set_no_esquerda(atual.get_no_esquerda());
            }

        }
        public Node getSucessor(Node deleleNode)
        {
            Node sucessorPai = deleleNode;
            Node sucessor = deleleNode;
            Node atual = deleleNode.get_no_direita();

            while (atual != null)
            {
                sucessorPai = sucessor;
                sucessor = atual;
                atual = atual.get_no_esquerda();
            }
            if (sucessor != deleleNode.get_no_direita())
            {
                sucessorPai.set_no_esquerda(sucessor.get_no_direita());
                sucessor.set_no_direita(deleleNode.get_no_direita());
            }

            return sucessor;
        }
        public void insere(int valor)
        {
            Node no_auxiliar;
            if (qntInterno == 0)
            {
                no_auxiliar = new Node();
                raiz = no_auxiliar;
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
            resultado = "";
            ApresentaNoEmOrdem(raiz);
            return resultado;
                
    }
        private void ApresentaNoEmOrdem(Node no)
        {
         
            if (no_externo(no))
            {
                return;
            }
            if (no != null)
            {
                ApresentaNoEmOrdem(no.get_no_esquerda());
                resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());
                ApresentaNoEmOrdem(no.get_no_direita());
            }
           
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
            if (no != null)
            {
                resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());
                ApresentaNoEmOrdem(no.get_no_esquerda());
                ApresentaNoEmOrdem(no.get_no_direita());
            }
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
            if (no != null)
            {
                ApresentaNoEmOrdem(no.get_no_esquerda());
                ApresentaNoEmOrdem(no.get_no_direita());
                resultado = resultado + " \n ═ " + Convert.ToInt32(no.get_valor());
            }
        }
    }
}

//   ║   ╣  ╗ ╝ ╚ ╔ ╩ ╦ ╠ ═ ╬ 