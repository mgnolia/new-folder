import java.util.Scanner;

public class Switch_4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("월(1~12)을 이볅 : ");
		int month = s.nextInt();
		switch (month) {
		case 3:
		case 4:
		case 5:
			System.out.println("봄 입니다.");
			break;
			
		case 6: case 7: case 8:
			System.out.println("여름 입니다.");
			break;
			
		case 9: case 10: case 11:
			System.out.println("가을 입니다.");
			break;
			
		case 12: case 1: case 2:
			System.out.println("겨울 입니다.");
			break;
			
		default:
			System.out.println(잘못 된 입력!);
			break;
			
		
		
		
		}
		

	}

}
