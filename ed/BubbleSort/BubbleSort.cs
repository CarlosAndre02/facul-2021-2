class BubbleSort {
    public void sort(int[] vet) {
        bool trocou = false;
        for (int j = 0; j < vet.Length; j++)
        {
            trocou = false;
            for (int i = 0; i < vet.Length - 1 - j; i++)
            {
                if (vet[i] > vet[i+1])
                {
                    int aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                    trocou = true;
                }
            }
            if (!trocou)
                return;
        }
    }
} 