import java.util.Scanner;

public class Class_201215 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("----------------");
		System.out.println("학점 관리 프로그램");
		System.out.println("----------------");
		System.out.println("100 ~ 90 : A학점");
		System.out.println("89 ~ 80 : B학점");
		System.out.println("79 ~ 70 : C학점");
		System.out.println("69 ~ 60  : D학점");
		System.out.println("59 ~ 0 : F학점");
				
		Scanner s = new Scanner(System.in);
		
		System.out.println("국어 점수 입력 : ");
		int kor = s.nextInt();
		System.out.println("영어 점수 입력 : ");
		int eng = s.nextInt();
		System.out.println("수학 점수 입력 : ");
		int math = s.nextInt();
		int hap = kor + eng + math;
		System.out.println("총점" +  hap);
		int ave = hap / 3;
		
		if (ave <= 100 && ave >= 90) {
			System.out.println("A학점");
		}
		else if (ave <= 89 && ave >= 80) {
			System.out.println("B학점");
		}
		else if (ave <= 79 && ave >= 70) {
			System.out.println("C학점");
		}
		else if (ave <= 69 && ave >= 60) {
			System.out.println("D학점");
		}
		else if (ave <= 59 && ave >= 50) {
			System.out.println("F학점");
		}
		
		
		s.close();
		

	}

}
