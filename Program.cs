string[] newArr = {"sdtf","dfw","rr","h","erfvsd","jkssssswefseg"," "};
var resultArr = newArr.Where(x=>x.Length < 4).ToArray();
for (int i = 0; i < resultArr.Length; i++)
      Console.Write(@"""{1},"" ", i, resultArr[i]);
