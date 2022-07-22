using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WookaoTalk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginUI : UserControl
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private byte[] ConvertSecureStringToByteArray(SecureString value)//문자열을 바이트로 변환(메모리에서 삭제되는 텍스트 value)
        {
            byte[] returnVal = new byte[value.Length];//반환할 값

            IntPtr valuePtr = IntPtr.Zero;//intPtr = 비트 너비가 포인터와 같은 부호 있는 정수
            try
            {
                valuePtr = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(value);
                //관리되는 SecureString 개체의 콘텐츠를 관리되지 않는 메모리로 복사
                for(int i = 0; i < value.Length; i++)
                {
                    short unicodeChar = System.Runtime.InteropServices.Marshal.ReadInt16(valuePtr, i * 2);
                    //관리되지 않는 메모리에서 16비트 부호 있는 정수를 읽습니다. 정렬되지 않은 메모리 위치에서 읽을 수 있다
                    returnVal[i] = Convert.ToByte(unicodeChar);
                }
            }
        }
    }
}
