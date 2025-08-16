public static class Algoritmo
{
    private static void Intercalar(int[] vetor, int esquerda, int meio, int direita)
    {
        // Calcula os tamanhos dos dois subvetores
        int tamanhoEsquerda = meio - esquerda + 1; // 1
        int tamanhoDireita = direita - meio; // 1


        // Cria vetores temporários para armazenar os elementos
        int[] vetorEsquerda = new int[tamanhoEsquerda]; // 1
        int[] vetorDireita = new int[tamanhoDireita]; // 1


        // Copia os elementos para os vetores temporários
        for (int i = 0; i < tamanhoEsquerda; i++) // 2n/2 => n
            vetorEsquerda[i] = vetor[esquerda + i]; // n/2


        for (int j = 0; j < tamanhoDireita; j++) // 2n/2 => n
            vetorDireita[j] = vetor[meio + 1 + j]; // n/2


        // Índices de controle para percorrer os vetores
        int indiceEsquerda = 0;   // posição atual do vetorEsquerda // 1
        int indiceDireita = 0;    // posição atual do vetorDireita // 1
        int indiceMesclado = esquerda; // posição no vetor original // 1


        // Enquanto ainda houver elementos em ambos os vetores
        while (indiceEsquerda < tamanhoEsquerda && indiceDireita < tamanhoDireita) // 3n
        {
            // Compara o menor elemento disponível em cada subvetor
            if (vetorEsquerda[indiceEsquerda] <= vetorDireita[indiceDireita]) // 1
            {
                vetor[indiceMesclado] = vetorEsquerda[indiceEsquerda]; // 1
                indiceEsquerda++; // 1
            }
            else
            {
                vetor[indiceMesclado] = vetorDireita[indiceDireita]; // 1
                indiceDireita++; // 1
            }
            indiceMesclado++; // 1
        }


        // Copia os elementos restantes do vetor da esquerda (se ainda houver)
        while (indiceEsquerda < tamanhoEsquerda) // n/2
        {
            vetor[indiceMesclado] = vetorEsquerda[indiceEsquerda]; // 1
            indiceEsquerda++; // 1
            indiceMesclado++; // 1
        }


        // Copia os elementos restantes do vetor da direita (se ainda houver)
        while (indiceDireita < tamanhoDireita) // n/2
        {
            vetor[indiceMesclado] = vetorDireita[indiceDireita]; // 1
            indiceDireita++; // 1
            indiceMesclado++; // 1
        }
    }


    /// <summary>
    /// Função principal do Merge Sort que divide o vetor em partes menores,
    /// ordena essas partes e depois as intercala.
    /// </summary>
    private static void MergeSort(int[] vetor, int esquerda, int direita)
    {
        if (esquerda < direita) // 1
        {
            // Encontra o ponto do meio
            int meio = esquerda + (direita - esquerda) / 2; // 1


            // Chamada recursiva para ordenar a metade esquerda
            MergeSort(vetor, esquerda, meio); // (7(t/2) + 21)


            // Chamada recursiva para ordenar a metade direita
            MergeSort(vetor, meio + 1, direita); // (7(t/2) + 21)


            // Junta as duas metades já ordenadas
            Intercalar(vetor, esquerda, meio, direita); // 7n + 19
        }
    }

    public static void Order(int[] vetor)
    {
        MergeSort(vetor, 0, vetor.Count() - 1);
    }
}
