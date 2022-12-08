// using System;
// using System.Threading;

// public class Time {

//    public static void Timer() {
//       Timer timer = new Timer(TimerCallback, null, 0, 1000);
//       // Console.ReadLine();
//    }

//    private static void TimerCallback(Object o) {
//       Console.WriteLine("In TimerCallback: " + DateTime.Now);
//    }
//    public static void  ResetTimer(){
//      Timer timer = new Timer(TimerCallback, null, 0 , 1000);
//    }
//    public bool CheckTimer(int timer){
//       if (timer > 0){
//          return false;
//       }
//       else {
//          return true; 
//       }
//    }
// }

// I commented this class out on line 12 & 105 in balls

// Timer example:
// using System;
// using System.Diagnostics;


// public class CountDownTimer : IDisposable
// {
//     public Stopwatch _stpWatch = new Stopwatch();

//     public Action TimeChanged;
//     public Action CountDownFinished;

//     public bool IsRunnign => timer.Enabled;

//     public int StepMs
//     {
//         get => timer.Interval;
//         set => timer.Interval = value;
//     }

//     private Timer timer = new Timer();

//     private TimeSpan _max = TimeSpan.FromMilliseconds(30000);

//     public TimeSpan TimeLeft => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) > 0 ? TimeSpan.FromMilliseconds(_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) : TimeSpan.FromMilliseconds(0);
    
//     private bool _mustStop => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) < 0;

//     public string TimeLeftStr => TimeLeft.ToString(@"\mm\:ss");

//     public string TimeLeftMsStr => TimeLeft.ToString(@"mm\:ss\.fff");

//     private void TimerTick(object sender, EventArgs e)
//     {
//         TimeChanged?.Invoke();

//         if (_mustStop)
//         {
//             CountDownFinished?.Invoke();
//             _stpWatch.Stop();
//             timer.Enabled = false;
//         }
//     }

//     public CountDownTimer(int min, int sec)
//     {
//         SetTime(min, sec);
//         Init();
//     }

//     public CountDownTimer(TimeSpan ts)
//     {
//         SetTime(ts);
//         Init();
//     }

//     public CountDownTimer()
//     {
//         Init();
//     }

//     private void Init()
//     {
//         StepMs = 1000;
//         timer.Tick += new EventHandler(TimerTick);
//     }

//     public void SetTime(TimeSpan ts)
//     {
//         _max = ts;
//         TimeChanged?.Invoke();
//     }

//     public void SetTime(int min, int sec = 0) => SetTime(TimeSpan.FromSeconds(min * 60 + sec));

//     public void Start() {
//         timer.Start();
//         _stpWatch.Start();
//     }

//     public void Pause()
//     {
//         timer.Stop();
//         _stpWatch.Stop();
//     }

//     public void Stop()
//     {
//         Reset();
//         Pause();
//     }
// }


// another timer example:
// private void Form1_Load(object sender, EventArgs e){
//         timer1.Interval = 1000;
//         timer1.Start();
// }

// private void timer1_Tick(object sender, EventArgs e){
//         if (int.Parse(label_time_left.Text) != 0){
//             int futureText = int.Parse(label_time_left.Text) - 1;
//             label_time_left.Text = futureText.ToString();
//         } else {
//             // actions when the timer ends 
//         }
// }


// Another timer example:
// using System;
// using System.Windows.Forms;

// namespace countdown_timer
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//         }
//         private int duration = 60;
//         private void button1_Click(object sender, EventArgs e)
//         {
//             timer1 = new System.Windows.Forms.Timer();
//             timer1.Tick += new EventHandler(count_down);
//             timer1.Interval = 1000;
//             timer1.Start();

//         }
//         private void count_down(object sender, EventArgs e)
//         {
            
//             if (duration == 0)
//             {
//                 timer1.Stop();

//             }
//             else if(duration > 0)
//             {
//                 duration--;
//                 label1.Text = duration.ToString();
//             }
//         }
//     }
// }