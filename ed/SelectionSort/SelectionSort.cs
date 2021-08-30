class SelectionSort {
    public void sort(int[] vet) {
        for(int j = 0; j < vet.Length; j++) {
            int menorIndice = j;
            for(int i = j+1; i < vet.Length; i++) {
                if(vet[i] < vet[menorIndice]) {
                    menorIndice = i;
                }
            }
            int aux = vet[j];
            vet[j] = vet[menorIndice];
            vet[menorIndice] = aux;
        }
    }
}