 using System;

public class OTPGenerator {
    
    public static int GenerateOTP() {
        Random random = new Random();
        return random.Next(100000, 999999);
    }

    public static bool AreUniqueOTPs(int[] otpArray) {
        for (int i = 0; i < otpArray.Length; i++) {
            for (int j = i + 1; j < otpArray.Length; j++) {
                if (otpArray[i] == otpArray[j]) {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Main() {
        int[] otpArray = new int[10];

        for (int i = 0; i < otpArray.Length; i++) {
            otpArray[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otpArray[i]}");
        }

        if (AreUniqueOTPs(otpArray)) {
            Console.WriteLine("All OTPs are unique.");
        } else {
            Console.WriteLine("There are duplicate OTPs.");
        }
    }
}

