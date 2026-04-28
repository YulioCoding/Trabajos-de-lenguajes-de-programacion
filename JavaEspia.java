import java.util.Scanner;

public class CasoDetective { 
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);  
        
        String nombre;
        int edad;
        int pistas = 0;
        int opcion;
        boolean casoResuelto = false;
        
        System.out.println("================================");
        System.out.println("DESPACHO & ASOCIADOS");
        System.out.println("Caso #1: HIDDEN");
        System.out.println("================================");
        
        System.out.print("Detective, ¿cuál es tu nombre? ");
        nombre = teclado.nextLine();
        
        System.out.print("¿Cuál es tu edad? ");
        edad = teclado.nextInt();
        
        if(edad < 18){
            System.out.println("¡Eres muy joven para ser detective, no lo puedes resolver");
        return;
        }else if(edad <= 59){
            System.out.println("¡Bienvenido al equipo de detectives!");
        } else {
            System.out.println("Detective senior con experiencia");
        } 
        
        System.out.println("");
        System.out.println("Bienvenido, detective " + nombre + ".");
        System.out.println("Tu misión: resolver el caso HIDDEN.");
        System.out.println("Necesitas al menos 3 pistas.");

        do {  
            System.out.println("\n--- MENÚ DEL DETECTIVE ---");
            System.out.println("1. Buscar pistas");
            System.out.println("2. Interrogar sospechosos");
            System.out.println("3. Resolver el caso"); 
            System.out.print("Elige una opción (1-3): ");
            
            opcion = teclado.nextInt();
            
            switch (opcion) {
                case 1: 
                    System.out.println("Buscando pistas...");
                    String[] evidencias = {
                        "Huella digital en la ventana",
                        "Copa de vino con residuos",
                        "Nota rasgada en el escritorio",
                        "Cuchillo en la cocina"
                    };
                
                    int i = 0; 
                    while (i < evidencias.length){
                        pistas++;
                        System.out.println("Pista #" + pistas + ": " + evidencias[i]);
                        i++;
                    }
                    
                    System.out.println("Total de pistas: " + pistas);
                    break;
            
                case 2:
                    System.out.println("\nInterrogatorios");
                    String[] sospechosos = {
                        "James Barnes", "Aurelio Vásquez", "Victoria Reyes", "Bruno Quiroga"
                    };
                
                    for (int j = 0; j < sospechosos.length; j++){
                        System.out.println("Interrogando a: " + sospechosos[j]);
                        System.out.println("-> Dice que es inocente...");
                    }          
                    break;
            
                case 3:
                    System.out.println("RESOLUCIÓN DEL CASO");
                
                    if (pistas >= 3) {
                        System.out.println("¡Tienes suficientes pistas!");
                        System.out.println("El culpable es: Aurelio Vásquez");
                        System.out.println("¡CASO RESUELTO, detective " + nombre + "!");
                        casoResuelto = true;
                    
                    } else if (pistas >= 1) { 
                        System.out.println("Tienes " + pistas + " pista(s). Necesitas 3.");
                        System.out.println("¡Sigue investigando!");
                    
                    } else { 
                        System.out.println("No tienes ninguna pista.");
                        System.out.println("Ve a buscar pistas primero.");
                    }
                    break;
            
                default:
                    System.out.println("Opción no válida");
                    break;
            } 
        } while (!casoResuelto);
        
        teclado.close();
    }
}
