//Microsoft (R) Visual C# Compiler version 3.4.0-beta4-19562-05 (ff930dec)
//Copyright (C) Microsoft Corporation. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            
            Dictionary<string, string> PA = new Dictionary<string, string>(){
                {"ip address 정보를 확인하는 명령어는?","ifconfig"},
                {"리눅스에서 파일이나 폴더를 찾을 때 사용하는 명령어?","find"},
                {"리눅스에서 현재설치된 하드디스크 용량확인하는 명령어?","df"},
                {"리눅스에서 현재위치를 확인하고싶을 때 사용 명령어?","pwd"},
                {"리눅스에서 도움말-메뉴얼을 확인하는 명령어? 또는 특정 명령어에 대한 설명을 보는 것?",
                 "man"},
                {"리눅스에서 포트/프로토콜 정보를 확인할 수 있는 명령어?","etc/ services"},
                {"리눅스에서 CPU메모리 사용정보를 확인하는 명령어","top"},
                {"드래그앤드롭문제(한문제나옴), 부팅메뉴를 선택하고 선택된 커널을 고정시키는 것","grub"},
                {"/etc/init 파일의 내용을 순차대로 실행하는 것","init"},
                {"부팅시 필요한 마운트정보를 가지고있는 것","etc/fstab"},
                {"네트워크의 연결상태와 라우팅 테이블정보가있는 dos창이 나오는 문제일 경우 이것과 관련된 명령어 암기하세요~","netstat"},
                {"리눅스에서 계정을 생성하는 과정이 사진으로 나왔는데 그럴 경우 답은","passwd"},
                {"문제에서 사진상으로 명령어를 입력시 경로가 나오고 cd명령어로 이동한 뒤 다시 명령어를 쳤을 때 그 경로가 나오는 자료일 경우, 현재 위치를 알려주는 명령어로써 정답은","pwd"},
                {"리눅스에서 사용자에 대한 특정한 파일을 찾고자 할 때 사용하는 명령어?","find"},
                {"리눅스 이동명령어?","mv"},
                {"리눅스 파일타입확인 명령어?","file"},
                {"리눅스 복사 명령어?","cp"},
                {"리눅스 강제종료하는 명령어","reboot, shutdown -r now, init 0"}
            };
            
            List<string> l = new List<string>(PA.Keys);
            
            foreach (string problem in l){
                Console.WriteLine(problem);
                Console.Write("답: ");
                string Answer = Console.ReadLine();
                if(Answer == PA[problem]){
                    Console.WriteLine("정답입니다.");
                }else{
                    Console.WriteLine("틀렸습니다. 정답은 " + PA[problem] + " 입니다");
                }
            }

            
        }
    }
}