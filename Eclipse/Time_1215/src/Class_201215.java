import java.util.Scanner;

public class Class_201215 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("----------------");
		System.out.println("���� ���� ���α׷�");
		System.out.println("----------------");
		System.out.println("100 ~ 90 : A����");
		System.out.println("89 ~ 80 : B����");
		System.out.println("79 ~ 70 : C����");
		System.out.println("69 ~ 60  : D����");
		System.out.println("59 ~ 0 : F����");
				
		Scanner s = new Scanner(System.in);
		
		System.out.println("���� ���� �Է� : ");
		int kor = s.nextInt();
		System.out.println("���� ���� �Է� : ");
		int eng = s.nextInt();
		System.out.println("���� ���� �Է� : ");
		int math = s.nextInt();
		int hap = kor + eng + math;
		System.out.println("����" +  hap);
		int ave = hap / 3;
		
		if (ave <= 100 && ave >= 90) {
			System.out.println("A����");
		}
		else if (ave <= 89 && ave >= 80) {
			System.out.println("B����");
		}
		else if (ave <= 79 && ave >= 70) {
			System.out.println("C����");
		}
		else if (ave <= 69 && ave >= 60) {
			System.out.println("D����");
		}
		else if (ave <= 59 && ave >= 50) {
			System.out.println("F����");
		}
		
		
		s.close();
		

	}

}
