import java.util.Random;
import java.util.HashMap;

public class PruebaPersonas{

	HashMap<Integer, String> nombresHombre = new HashMap<Integer, String>(20);
	HashMap<Integer, String> nombresMujer = new HashMap<Integer, String>(20);
	HashMap<Integer, String> apellidos = new HashMap<Integer, String>(30);

	private static String generacionCURP(){
		Random rand = new Random();
		char arraglo [] = new char[18];
		for(int i = 0; i < 18; i++){
			int num = (rand.nextInt(42) + 48);
			if(num >= 58 && num <= 64)
				num += 7;
			arraglo[i] = (char)(num);					
		}
		return String.valueOf(arraglo);
	}

	private void hashMapNombersHombre(){		
		nombresHombre.put(1, "Marco");
		nombresHombre.put(2, "Christopher");
		nombresHombre.put(3, "Eduardo");
		nombresHombre.put(4, "Max");
		nombresHombre.put(5, "Alejandro");
		nombresHombre.put(6, "Armando");
		nombresHombre.put(7, "Santiago");
		nombresHombre.put(8, "Juan Pablo");
		nombresHombre.put(9, "Hugo");
		nombresHombre.put(10, "Ricardo");
		nombresHombre.put(11, "Gustavo");
		nombresHombre.put(12, "Jose");
		nombresHombre.put(13, "Javier");
		nombresHombre.put(14, "Fernando");
		nombresHombre.put(15, "Martin");
		nombresHombre.put(16, "Juan Jose");
		nombresHombre.put(17, "Rafael");
		nombresHombre.put(18, "Luis");
		nombresHombre.put(19, "Mauricio");
		nombresHombre.put(20, "Antonio");		
	}

	private void hashMapNombersMujer(){		
		nombresMujer.put(1, "Maria");
		nombresMujer.put(2, "Blanca");
		nombresMujer.put(3, "Mariana");
		nombresMujer.put(4, "Maru");
		nombresMujer.put(5, "Alejandra");
		nombresMujer.put(6, "Regina");
		nombresMujer.put(7, "Elizabeth");
		nombresMujer.put(8, "Martha");
		nombresMujer.put(9, "Guadalupe");
		nombresMujer.put(10, "Raquel");
		nombresMujer.put(11, "Gisela");
		nombresMujer.put(12, "Juana");
		nombresMujer.put(13, "Susana");
		nombresMujer.put(14, "Ximena");
		nombresMujer.put(15, "Ana");
		nombresMujer.put(16, "Fernada");
		nombresMujer.put(17, "Cecilia");
		nombresMujer.put(18, "Rosario");
		nombresMujer.put(19, "Lisa");
		nombresMujer.put(20, "Beatriz");		
	}

	private void hashMapApellidos(){		
		apellidos.put(1, "Gonzalez");
		apellidos.put(2, "Bermudez");
		apellidos.put(3, "Martinez");
		apellidos.put(4, "Gutierrez");
		apellidos.put(5, "Ezquivel");
		apellidos.put(6, "Rodriguez");
		apellidos.put(7, "Hernandez");
		apellidos.put(8, "Rojo");
		apellidos.put(9, "Garcia");
		apellidos.put(10, "Murcer");
		apellidos.put(11, "Guyen");
		apellidos.put(12, "Jirazol");
		apellidos.put(13, "Serrano");
		apellidos.put(14, "Cerdo");
		apellidos.put(15, "Jirafa");
		apellidos.put(16, "Saponeta");
		apellidos.put(17, "Martiale");
		apellidos.put(18, "Rincon");
		apellidos.put(19, "Luciernaga");
		apellidos.put(20, "Betral");
		apellidos.put(22, "Oceano");
		apellidos.put(22, "Tumbas");
		apellidos.put(23, "Selacanto");
		apellidos.put(24, "Cerrujo");
		apellidos.put(25, "Jernation");
		apellidos.put(26, "Samita");
		apellidos.put(27, "Wesley");
		apellidos.put(28, "Huges");
		apellidos.put(29, "Marinela");
		apellidos.put(30, "Lagones");		
	}

	private String genracionNombre(boolean esH){
		String nombre = null;
		Random rand = new Random();
		if(esH)
			nombre = nombresHombre.get(rand.nextInt(20));
		else
			nombre = nombresMujer.get(rand.nextInt(20));
		nombre += " ";
		nombre += apellidos.get(rand.nextInt(30));
		nombre += " ";
		nombre += apellidos.get(rand.nextInt(30));
		return nombre;
	}

	private static String generacionFecha(){
		String fecha;
		Random rand = new Random();
		int ano = rand.nextInt(50) + 1950;
		int mes = rand.nextInt(12) + 1;
		int dia = rand.nextInt(28) + 1;
		fecha = Integer.toString(ano) + "-" + Integer.toString(mes) + "-" + Integer.toString(dia);
		return fecha;
	}

	private static Boolean generacionBoolean(){
		Random rand = new Random();
		int i = rand.nextInt(2);
		if(i == 0)
			return true;
		else
			return false;
	}

	private static String generacionTelefono(){
		Random rand = new Random();
		int num = rand.nextInt() + 10000;
		if(num < 0){
			num *= -1;
		}
		return Integer.toString(num);
	}

	private static int generacionID_periodo(){
		Random rand = new Random();
		return rand.nextInt(8) + 1;
	}


	public static void main (String args[]){

		PruebaPersonas prueba = new PruebaPersonas();
		prueba.hashMapNombersHombre();
		prueba.hashMapNombersMujer();
		prueba.hashMapApellidos();
		System.out.println(prueba.genracionNombre(false));
		System.out.println(generacionCURP());
		System.out.println(generacionFecha());
		System.out.println(generacionBoolean());
		System.out.println(generacionTelefono());

		int i = 20;

		
		
		System.exit(0);
	}
}