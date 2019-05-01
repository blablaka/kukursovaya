public class Solution {
    public static void recursion(int sum, int count) {
        java.util.Scanner in = new java.util.Scanner(System.in);
        int n = in.nextInt();
        // Базовый случай
        if (n > 0) {
            // Шаг рекурсии / рекурсивное условие
            recursion(sum + n, ++count);
        } else if (sum > 0 && count > 0) {
            System.out.println((float) sum / count);
        }
    }
    public static void main(String[] args) {
        recursion(0, 0); // вызов рекурсивной функции
    }
}