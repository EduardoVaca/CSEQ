import java.util.Random;
import java.util.HashMap;

public class PruebaPersonas{

	HashMap<Integer, String> nombresHombre = new HashMap<Integer, String>(50);
	HashMap<Integer, String> nombresMujer = new HashMap<Integer, String>(50);
	HashMap<Integer, String> apellidos = new HashMap<Integer, String>(50);
	HashMap<Integer, String> empleos = new HashMap<Integer, String>(15);
	HashMap<Integer, String> companias = new HashMap<Integer, String>(15);
	Random rand = new Random();

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
		nombresHombre.put(21, "Cesar");
		nombresHombre.put(22, "Manuel");
		nombresHombre.put(23, "Enrique");
		nombresHombre.put(24, "Tomas");
		nombresHombre.put(25, "Guillermo");
		nombresHombre.put(26, "Saul");
		nombresHombre.put(27, "Daniel");
		nombresHombre.put(28, "Diego");
		nombresHombre.put(29, "Raul");
		nombresHombre.put(30, "Ismael");
		nombresHombre.put(31, "Julian");
		nombresHombre.put(32, "Tobias");
		nombresHombre.put(33, "Matias");
		nombresHombre.put(34, "Jeronimo");
		nombresHombre.put(35, "Plutarco");
		nombresHombre.put(36, "Neptuno");
		nombresHombre.put(37, "Serafin");
		nombresHombre.put(38, "Pinguin");
		nombresHombre.put(39, "Yamal");
		nombresHombre.put(40, "Girasol");
		nombresHombre.put(41, "Beto");
		nombresHombre.put(42, "Francisco");
		nombresHombre.put(43, "Ruiodoso");
		nombresHombre.put(44, "Emiliano");
		nombresHombre.put(45, "Pabel");
		nombresHombre.put(46, "Emmanuel");
		nombresHombre.put(47, "Hermenejildo");
		nombresHombre.put(48, "Jamon");
		nombresHombre.put(49, "Chicharron");
		nombresHombre.put(50, "Pedro");		
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
		nombresMujer.put(21, "Samantha");
		nombresMujer.put(22, "CLaudia");
		nombresMujer.put(23, "Vanesa");
		nombresMujer.put(24, "Perla");
		nombresMujer.put(25, "Galaxia");
		nombresMujer.put(26, "Estrella");
		nombresMujer.put(27, "Risitas");
		nombresMujer.put(28, "Ileana");
		nombresMujer.put(29, "Sofia");
		nombresMujer.put(30, "Andrea");
		nombresMujer.put(31, "Monica");
		nombresMujer.put(32, "Sandra");
		nombresMujer.put(33, "Maria Jose");
		nombresMujer.put(34, "Sandia");
		nombresMujer.put(35, "America");
		nombresMujer.put(36, "Europa");
		nombresMujer.put(37, "Antartida");
		nombresMujer.put(38, "Itzel");
		nombresMujer.put(39, "Denise");
		nombresMujer.put(40, "Willia");	
		nombresMujer.put(41, "Julia");
		nombresMujer.put(42, "Isabella");
		nombresMujer.put(43, "Paulina");
		nombresMujer.put(44, "Carmela");
		nombresMujer.put(45, "Margot");
		nombresMujer.put(46, "Clericot");
		nombresMujer.put(47, "Norma");	
		nombresMujer.put(48, "Alicia");
		nombresMujer.put(49, "Elba Alicia");
		nombresMujer.put(50, "Otilia");
	}

	private void hashMapApellidos(){
		apellidos.put(0, "Ramirez");	
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
		apellidos.put(21, "Oceano");
		apellidos.put(22, "Tumbas");
		apellidos.put(23, "Selacanto");
		apellidos.put(24, "Cerrujo");
		apellidos.put(25, "Jernation");
		apellidos.put(26, "Samita");
		apellidos.put(27, "Wesley");
		apellidos.put(28, "Huges");
		apellidos.put(29, "Marinela");
		apellidos.put(30, "Lagones");
		apellidos.put(31, "Choco Roles");
		apellidos.put(32, "Campos");
		apellidos.put(33, "Quesos");
		apellidos.put(34, "Ribas");
		apellidos.put(35, "Baca");
		apellidos.put(36, "Venado");
		apellidos.put(37, "Corral");
		apellidos.put(38, "Cuevas");
		apellidos.put(39, "Dragone");
		apellidos.put(40, "Lagones");
		apellidos.put(41, "Guerra");
		apellidos.put(42, "Ojeda");
		apellidos.put(43, "Hasburgo");
		apellidos.put(44, "Plutarco");
		apellidos.put(45, "Peña Nieto");
		apellidos.put(46, "Cardenas");
		apellidos.put(47, "Juarez");
		apellidos.put(48, "Hidalgo");
		apellidos.put(49, "Saturno");
		apellidos.put(50, "Willliam Primero Del la Fila");
	}

	private void hashMapEmpleos(){
		empleos.put(1, "Registrar contactos de agenda");
		empleos.put(2, "Agendar eventos");
		empleos.put(3, "Generacion de imagenes publicitarias");
		empleos.put(4, "Consejero general");
		empleos.put(5, "Generador de cotizaciones");
		empleos.put(6, "Evaluador de proyectos");
		empleos.put(7, "Conserge de piso");
		empleos.put(8, "Secretario de planta");
		empleos.put(9, "Capturador de datos");
		empleos.put(10, "Mantenimiento de  servidores");
		empleos.put(11, "Guardia de seguridad");
		empleos.put(12, "Vigilante nocturno");
		empleos.put(13, "Atencion a clientes");
		empleos.put(14, "Recibidor de quejas");
		empleos.put(15, "Masajista");
	}

	private void hashMapCompanias(){
		companias.put(1, "Mabe");
		companias.put(2, "PNG");
		companias.put(3, "Kellogs");
		companias.put(4, "General Electric");
		companias.put(5, "Bombardier");
		companias.put(6, "iCorp");
		companias.put(7, "Soriana");
		companias.put(8, "Cinemex");
		companias.put(9, "Palacio de Hierro");
		companias.put(10, "Toyota");
		companias.put(11, "Mazda");
		companias.put(12, "McDonalds");
		companias.put(13, "Tec de Monterrey");
		companias.put(14, "Construcciones ASM");
		companias.put(15, "Imagination");
	}

	private String generacionNombre(boolean esH){
		String nombre = null;
		Random rand = new Random();
		if(esH)
			nombre = nombresHombre.get(rand.nextInt(50) + 1);
		else
			nombre = nombresMujer.get(rand.nextInt(50) + 1);
		nombre += " ";
		nombre += apellidos.get(rand.nextInt(51));
		nombre += " ";
		nombre += apellidos.get(rand.nextInt(51));
		return nombre;
	}

	private String generacionFecha(){
		String fecha;
		Random rand = new Random();
		int ano = rand.nextInt(50) + 1950;
		int mes = rand.nextInt(12) + 1;
		int dia = rand.nextInt(28) + 1;
		fecha = Integer.toString(ano) + "-" + Integer.toString(mes) + "-" + Integer.toString(dia);
		return fecha;
	}

	private Boolean generacionBoolean(){
		Random rand = new Random();
		int i = rand.nextInt(2);
		if(i == 0)
			return true;
		else
			return false;
	}

	private String generacionTelefono(){
		Random rand = new Random();
		int num = rand.nextInt() + 10000;
		if(num < 0){
			num *= -1;
		}
		return Integer.toString(num);
	}

	private int generacionID_periodo(){		
		return rand.nextInt(8) + 1;
	}

	private int generacionID_censo(){		
		return rand.nextInt(3) + 2010;
	}

	private int generacionID_colonia(){		
		return rand.nextInt(11) + 1;
	}

	private int generacionID_estadoCivil(){		
		return rand.nextInt(4) + 1;
	}

	private int generacionID_nivelEducativo(){		
		return rand.nextInt(9) + 1;
	}

	private int generacionID_institucionEducativa(){		
		return rand.nextInt(4) + 1;
	}

	private int generacionAno_estudio(){
		return rand.nextInt(15) + 1850;
	}

	private int generacionID_lenguaDominante(){
		return rand.nextInt(4) + 1;
	}

	private int generacionID_nivelLengua(){
		return rand.nextInt(4) + 1;
	}

	private String generacionDescripcionEmpleo(){
		return empleos.get(rand.nextInt(15) + 1);
	}

	private String generacionCompania(){
		return companias.get(rand.nextInt(15) + 1);
	}

	private int generacionID_areaTrabajo(){
		return rand.nextInt(8) + 1;
	}

	private int generacionID_sueldo(){
		return rand.nextInt(3) + 1;
	}

	private int generacionID_perdidaAuditiva(){
		return rand.nextInt(5) + 1;		
	}

	private int generacionID_grado(){
		return rand.nextInt(5) + 1;	
	}

	private int generacionID_causa(){
		return rand.nextInt(8) + 1;		
	}

	private int generacionID_aparatoAuditivo(){
		return rand.nextInt(6) + 1;
	}

	private int generacionModelo(){
		return rand.nextInt(3000) + 100;
	}


	public static void main (String args[]){

		PruebaPersonas prueba = new PruebaPersonas();
		prueba.hashMapNombersHombre();
		prueba.hashMapNombersMujer();
		prueba.hashMapApellidos();
		prueba.hashMapEmpleos();
		prueba.hashMapCompanias();
		Boolean sexo;
		int numero_registros = 100;

		while(numero_registros > 0){
			numero_registros--;
			sexo = prueba.generacionBoolean();
			String consultaMySQL = "CALL registrarPersonaCOMPLETO(";
			consultaMySQL += "'" + prueba.generacionCURP() + "','" + prueba.generacionNombre(sexo) + "','"; 
						// 				CURP 								 Nombre
			consultaMySQL += prueba.generacionFecha() + "'," + sexo + ",'" + prueba.generacionTelefono() + "','"; 
						//		Fecha 							sexo 			 telefono
			consultaMySQL += "',''," + prueba.generacionBoolean() + "," + prueba.generacionBoolean() + "," + prueba.generacionBoolean() + ","; 
						//correo / calle / examen 							implante 							comunidad
			consultaMySQL += prueba.generacionBoolean() + "," + prueba.generacionBoolean() + "," + prueba.generacionBoolean() + "," + prueba.generacionBoolean() + ",";
						// 		alergia							enfermedad   							mexicano							ife
			consultaMySQL += prueba.generacionID_periodo() + "," + prueba.generacionID_censo() + "," + prueba.generacionID_colonia() + ",";
						// 		periodo 							censo 								colonia
			consultaMySQL += prueba.generacionID_estadoCivil() + "," + prueba.generacionID_nivelEducativo() + "," + prueba.generacionID_institucionEducativa() + ",";
						// 		estadoCivil 								Nivel Educativo 							Institucion educativa	
			consultaMySQL += prueba. generacionAno_estudio() + "," + prueba.generacionID_lenguaDominante() + "," + prueba.generacionID_nivelLengua() + ",";
						// 		ano Estudio 							Lengua Dominante 								Nivel Espanol
			consultaMySQL += prueba.generacionID_nivelLengua() + "," + prueba.generacionID_nivelLengua() + ",'" + prueba.generacionDescripcionEmpleo() + "','";
						//		Nivel Ingles								Nivel LSM									Descripcion Empleo
			consultaMySQL += prueba.generacionCompania() + "','','" + prueba.generacionTelefono() + "',''," + prueba.generacionBoolean() +  ",";
						//		Compania 					correoC			Telefono compania 			Calle 		Interpretacion LSM	
			consultaMySQL += prueba.generacionID_areaTrabajo() + "," + prueba.generacionID_sueldo() + "," + prueba.generacionID_colonia() + ",";
						// 		Area trabajo 								Sueldo 								Colonia Empleo
			consultaMySQL += prueba.generacionID_perdidaAuditiva() + "," + prueba.generacionBoolean() + "," + prueba.generacionID_grado() + ",";
						// 		Perdidia Auditiva 								Prelinguistica 					Grado Perdida
			consultaMySQL += prueba.generacionBoolean() + "," + prueba.generacionID_causa() + "," + prueba.generacionID_aparatoAuditivo() + ",";
						// 		Bilateral							Causa 										Aparato Auditivo
			consultaMySQL += prueba.generacionModelo() + "," + prueba.generacionBoolean() + "," + prueba.generacionBoolean() + ");\n";
						//		Modelo 								TieneEmpleo							TieneAparato
			System.out.println(consultaMySQL);
		}
		System.exit(0);		
	}
}