package circle;

public class score {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int kor = 0;
		int eng = 0;
		int math = 0;
		int Sc = 0;
		kor = 90;
		eng = 80;
		math = 70;
		Sc = 60;
		
		float average = (kor + eng + math + Sc)/4.0f;
		int total = (kor + eng + math + Sc);
		System.out.println("����"+kor);
		System.out.println("����"+eng);
		System.out.println("����"+math);
		System.out.println("����"+Sc);
		System.out.println("average "+ average);
		System.out.println("total "+ total);
				

	}

}
