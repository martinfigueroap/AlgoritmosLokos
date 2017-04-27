
import java.util.Random;

public class RSAencryption {

	public static void main(String[] args) {
		long[][] keys = genKeys();
		System.out.print("Public keys: ");
		for (long i : keys[0]) {
			System.out.print(i + ", ");
		}
		System.out.println();
		System.out.print("Private keys: ");
		for (long i : keys[1]) {
			System.out.print(i + ", ");
		}

		System.out.println("\n");

		long encrypt = encrypt(6194, 479, 132271);
		System.out.println("CORA => " + encrypt);

		long decrypt = decrypt(53551, 37585, 105877);
		System.out.println("Mensaje 53551: " + decrypt);
	}

	static long p, q, n, fn, e = 51, d;

	public static long[][] genKeys() {
		Random random = new Random();
		p = random.nextInt(300) + 200;
		q = random.nextInt(300) + 200;
		//p = 281;
		//q = 167;

		while (!isPrime(p)) {
			p++;
		}
		while (!isPrime(q)) {
			q++;
		}

		n = p * q;
		fn = (p - 1) * (q - 1);
		while (!isRelativePrime(e, fn)) {
			e += 2;
		}
		if (mles(e, 1, fn) != null) {
			d = mles(e, 1, fn).longValue();
		}

		long[] P = { e, n };

		long[] S = { d, n };

		long[][] keys = { P, S };

		return keys;
	}

	private static boolean isPrime(long numero) {
		long i = 2;
		boolean isPrime = true;
		while ((isPrime) && (i != numero)) {
			if (mod(numero, i) == 0)
				isPrime = false;
			i++;
		}
		return isPrime;
	}

	private static long decrypt(long message, long d, long n) {
		return modular(message, d, n);
	}

	private static long encrypt(long message, long e, long n) {
		return modular(message, e, n);
	}

	private static long modular(long a, long b, long n) {
		long d = 1;
		String binary = Integer.toBinaryString((int)b);
		for (int i = binary.length() - 1; i >= 0; i--)
		{
			d = (d * d) % n;
			if (binary.charAt(binary.length() - 1 - i) == '1')
			{
				d = (d * a) % n;
			}
		}

		return d;
	}

	private static long xFromExtendedEuclid(long a, long b) {
		return extendedEuclid(a, b)[2];
	}

	private static long[] extendedEuclid(long a, long b) {
		if (b == 0) {
			return new long[] { a, 1, 0 };
		}
		long[] array = extendedEuclid(b, mod(a, b));
		long d = array[0];
		long x = array[2];
		long y = array[1] - (long) Math.floor(a / b) * array[2];
		return new long[] { d, x, y };
	}

	private static boolean isRelativePrime(long a, long b) {
		return GCD(a, b) == 1;
	}

	private static long GCD(long a, long b) {
		return b == 0 ? a : GCD(b, a % b);
	}

	private static Long mles(long a, long b, long n) {
		long[] dxy = extendedEuclid(a, n);
		if (mod(dxy[0], b) == 0) {
			long aux = (dxy[1] * (b / dxy[0]));
			long x0 = mod(aux, n);
			for (int i = 0; i <= dxy[0] - 1; i--) {
				return (x0 + i * mod((n / dxy[0]), n));
			}
		}
		return null;
	}

	private static long mod(long a, long b) {
		return (a > 0 ? a % b : a - Math.floorDiv(a, b) * b);
	}
}
