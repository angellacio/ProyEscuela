package edu.TecMilenio;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.*;

public class Practica_03_Deck {
    private static HashMap<Integer, Practica_03_Card> Baraja = null;

    public static void CargaDatosInicio(){
        int nRenglonP = 0;
        Baraja = new HashMap<>();
        for (int nR = 0; nR < 4; nR++) {
            String sPalo = "", sColor = "";
            if (nR == 0){
                sPalo = "Corazones";
                sColor = "Rojo";
            }
            else if (nR == 1){
                sPalo = "Diamantes";
                sColor = "Rojo";
            }
            else if (nR == 2){
                sPalo = "Tréboles";
                sColor = "Negro";
            }
            else if (nR == 3){
                sPalo = "Picas";
                sColor = "Negro";
            }

            for (int nRV = 0; nRV < 14; nRV++) {
                String sValor = "";
                if (nRV == 0) sValor = "A";
                else if (nRV == 11) sValor = "J";
                else if (nRV == 12) sValor = "Q";
                else if (nRV == 13) sValor = "K";
                else sValor = String.valueOf(nRV);

                Baraja.put(nRenglonP, new Practica_03_Card(sPalo, sColor, sValor));
                nRenglonP++;
            }
        }
    }
    public static void RealizaAccionesActividad(){
        BufferedReader datoCapturaB = new BufferedReader(new InputStreamReader(System.in));
        String sOpcionCol = "";
        boolean bolSigeEvidencia = true;
        try {
            do{
                System.out.println("\n");
                System.out.println("   ** Manejo de Colecciones **\n");
                System.out.println("        1 - Shuffle");
                System.out.println("        2 - Head");
                System.out.println("        3 - Pick");
                System.out.println("        4 - Hand");
                System.out.println("        X/x - Regresar Menu Principal.\n");
                System.out.print("Favor de especificar la opción deseada: ");

                sOpcionCol = datoCapturaB.readLine().toString().trim().toUpperCase();

                switch (sOpcionCol) {
                    case "1":
                        Shuffle();
                        break;
                    case "2":
                        Head();
                        break;
                    case "3":
                        Pick();
                        break;
                    case "4":
                        Hand();
                        break;
                    case "X":
                        bolSigeEvidencia = false;
                        break;
                    default:
                        System.out.println("");
                        System.out.println("El tipo de dato ingresado no es correcto, ingresar un dato valido.");
                        System.out.println("");
                        RealizaAccionesActividad();
                        break;
                }
                sOpcionCol = "";
            } while (bolSigeEvidencia);
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }

    public static void Shuffle(){
        BufferedReader datoCapturaB = null;
        try {
            datoCapturaB = new BufferedReader(new InputStreamReader(System.in));
            List<Integer> keys = new ArrayList(Baraja.keySet());
            Collections.shuffle(keys);
            HashMap<Integer, Practica_03_Card> shuffledBaraja = new HashMap<>();
            for (Integer nR = 0; nR < keys.size(); nR++) {
                Integer nIDBaraja = keys.get(nR).intValue();
                shuffledBaraja.put(nIDBaraja, Baraja.get(nIDBaraja));
            }
            Baraja = shuffledBaraja;
            System.out.println("");
            System.out.println("Se mezcló el Deck.");
            System.out.println("\n\n");
            System.out.print("Presione ENTER para continuar. ");
            datoCapturaB.readLine().toString().trim().toUpperCase();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }

    public static void Head(){
        BufferedReader datoCapturaB = null;
        try {
            datoCapturaB = new BufferedReader(new InputStreamReader(System.in));

            System.out.println("\n\n");
            BorraRenglon(new Integer[] { 0 });
            System.out.println("Quedan " + Baraja.size());
            System.out.println("\n\n");
            System.out.print("Presione ENTER para continuar. ");
            datoCapturaB.readLine().toString().trim().toUpperCase();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }
    public static void Pick(){
        BufferedReader datoCapturaB = null;
        Random aleatorio = null;
        Integer[] nRenglonBorrar = null;
        try {
            nRenglonBorrar = new Integer[1];
            datoCapturaB = new BufferedReader(new InputStreamReader(System.in));

            aleatorio = new Random();
            nRenglonBorrar[0] = aleatorio.nextInt(Baraja.size());

            System.out.println("\n\n");
            BorraRenglon(nRenglonBorrar);
            System.out.println("Quedan " + Baraja.size());
            System.out.println("\n\n");
            System.out.print("Presione ENTER para continuar. ");
            datoCapturaB.readLine().toString().trim().toUpperCase();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }
    public static void Hand(){
        BufferedReader datoCapturaB = null;
        Random aleatorio = null;
        Integer[] nRenglonBorrar = null;
        try {
            nRenglonBorrar = new Integer[5];
            datoCapturaB = new BufferedReader(new InputStreamReader(System.in));

            aleatorio = new Random();
            nRenglonBorrar[0] = aleatorio.nextInt(Baraja.size() / 5);
            nRenglonBorrar[1] = aleatorio.nextInt(Baraja.size() / 4);
            nRenglonBorrar[2] = aleatorio.nextInt(Baraja.size() / 3);
            nRenglonBorrar[3] = aleatorio.nextInt(Baraja.size() / 2);
            nRenglonBorrar[4] = aleatorio.nextInt(Baraja.size());

            System.out.println("\n\n");
            BorraRenglon(nRenglonBorrar);
            System.out.println("Quedan " + Baraja.size());
            System.out.println("\n\n");
            System.out.print("Presione ENTER para continuar. ");
            datoCapturaB.readLine().toString().trim().toUpperCase();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }

    private static void BorraRenglon(Integer[] nRBorrar) {
        Integer nRB = 0, nRM = 0, nRenglonBorrar = 0;
        Integer[] nRBId = new Integer[nRBorrar.length];

        for (nRB = 0; nRB < nRBorrar.length; nRB++){
            nRenglonBorrar = nRBorrar[nRB];
            nRM = 0;
            for (Map.Entry<Integer, Practica_03_Card> item : Baraja.entrySet()) {
                if (nRenglonBorrar == nRM) {
                    nRBId[nRB] = item.getKey();
                }
                nRM++;
            }
        }
        for (nRB = 0; nRB < nRBId.length; nRB++){
            nRenglonBorrar = nRBId[nRB];
            for (Map.Entry<Integer, Practica_03_Card> item : Baraja.entrySet()) {
                if (nRenglonBorrar == item.getKey()) {
                    item.getValue().RenglonBorrar();
                    Baraja.remove(item.getKey());
                    break;
                }
            }
            Integer nRRRRR = 0;
        }
    }
}
