/*
It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride! 
There are a number of people queued up, and each person wears a sticker indicating their initial position in the queue. 
Initial positions increment by  from  at the front of the line to  at the back.

Any person in the queue can bribe the person directly in front of them to swap positions. 
If two people swap positions, they still wear the same sticker denoting their original places in line. 
One person can bribe at most two others. For example, if and  bribes , the queue will look like this: .

Fascinated by this chaotic queue, 
you decide you must know the minimum number of bribes that took place to get the queue into its current state!


*/




    static void minimumBribes(int[] q) {
        int ans = 0;
        for (int i = q.Length - 1; i >= 0; i--) {

            if (q[i] - (i + 1) > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            {
                if (q[j] > q[i])
                {
                    ans++;
                } 
            }              
        }   
        Console.WriteLine(ans);
    }
