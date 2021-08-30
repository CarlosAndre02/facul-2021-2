class InsertionSort {
    public void sort(int[] vet) {
        for(int i = 0; i < vet.Length; i++) {
            int aux = vet[i];
            int indice = i;
            while(indice > 0 && aux < vet[indice-1]) {
                // movendo numeros para frente
                vet[indice] = vet[indice-1];
                indice--;
            }
            // inserindo no lugar correto
            vet[indice] = aux;
        }
    }
}