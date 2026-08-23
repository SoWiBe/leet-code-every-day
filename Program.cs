using LeetApp.subj.August.Session22;
using LeetApp.subj.August.Session23;

// Session22 session = new Session22();
// Console.WriteLine(session.CheckInclusion("acb", "eidbaooo"));

Session23 session23 = new Session23();

// Console.WriteLine(session23.MaxArea([1,8,6,2,5,4,8,3,7]));
foreach (var t in session23.TwoSum([2, 7, 11, 15], 9))
{
    Console.WriteLine(t);
}
foreach (var t in session23.TwoSum([-5,-3,0,2,4,6,8], 5))
{
    Console.WriteLine(t);
}

