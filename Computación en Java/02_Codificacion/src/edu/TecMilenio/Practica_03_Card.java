package edu.TecMilenio;

public class Practica_03_Card {
    private String palo;
    private String color;
    private String valor;

    public Practica_03_Card(String Palo, String Color, String Valor) {
        palo = Palo;
        color = Color;
        valor = Valor;
    }

    public void RenglonBorrar() {
        System.out.println(palo + ", " + color + ", " + valor);
    }
    public String PaloGet() { return palo; }
    public String ColorGet() { return color; }
    public String ValorGet() { return valor; }
}

