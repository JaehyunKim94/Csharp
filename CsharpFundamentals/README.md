# C# Basics for Beginners: Learn C# Fundamentals by Coding

## 01. Introduction to C# and .NET Framework

[Visual Studio 2019 Download](https://visualstudio.microsoft.com/ko/thank-you-downloading-visual-studio/?sku=Community&rel=16)

- C# vs .NET

  - C#: 개발 언어

    - C나 C++와는 달리 컴파일하면 CIL(Common Intermediate Langauge code)가 된다. > 플랫폼 간 상호 운용성에 용이

  - .NET:  윈도우에서 Application을 만들기 위한 프레임워크

    - CLR (Common Language Runtime)

      - CIL 코드를 읽어들여 OS가 이해할 수 있는 Native Code로 변환

    - Class Library

    - Architecture

      - `class`라 불리는 블록으로 이루어짐

        - 클래스는 attributes(속성)와 functions(함수)가 있다.
          - 자동차에는 제조사, 모델, 색과 같은 속성과 시동, 움직임과 같은 함수가 있다.
  
- `namespace`: 관련된 여러 개의 클래스를 묶는 컨테이너
      - `Assembly`: 관련 네임 스페이스에 대한 컨테이너
  
- `Application`: 어플리케이션을 컴파일 할 때, 컴파일러는 파티션 방식에 따라 하나 이상의 어셈블리를 빌드한다. 
  
- Demo
  
  - [First Application Hello World](./Demos/Chap01/HelloWorld)
  
    | 단축키           | 기능                |
    | ---------------- | ------------------- |
    | Ctrl + X         | 해당 줄 제거        |
    | Alt + Enter      | 불필요한 Using 제거 |
    | Ctrl + F5        | 어플리케이션 실행   |
    | Ctrl + Shift + B | 빌드                |
  
- [Download ReSharper](https://www.jetbrains.com/resharper/) (VS용 플러그인)

  - 설치 후 인증하면 됨
  - 학생용 또는 오픈 소스용 Jetbrain 계정이 있을 경우 무료
  - 아닐 경우 30일 체험판 사용



## 02. Primitive Types & Expressions

- Variables and Constants

  - Variables: 메모리에 저장 위치에 부여하는 이름
  - Constants: 변하지 않는 값

  ```csharp
  int number;					// identier
  int Number = 1;
  const float Pi = 3.14f;
  ```

  - number, Number, Pi를 identifier라고 한다.

    - `Identifier`(식별자)
      - 숫자로 시작 X
      - 여백이 포함되면 안됨
      - 예약어는 사용 불가
      - 의미를 나타내는 이름으로 짓자

  - Naming Conventions

    - For local variables: camelCase
    - For constants: PascalCase

  - Primitive Types

    |                                | C# Type | .NET Type | Bytes | Range                       |
    | ------------------------------ | ------- | --------- | ----- | --------------------------- |
    | **Integral Numbers**           | byte    | Byte      | 1     | 0 to 255                    |
    |                                | short   | Int 16    | 2     | -32,768 to 32767            |
    |                                | int     | Int 32    | 4     | -2.1B to 2.1B               |
    | **Real Number**                | long    | Int 64    | 8     | ...                         |
    |                                | float   | Single    | 4     | -3.4 x 10^38 to 3.4 x 10^38 |
    | C# real number  기본 data type | double  | Double    | 8     | ...                         |
    |                                | decimal | Decimal   | 16    | -7.9 x 10^28 to 7.9 x 10^28 |
    | **Character**                  | char    | Char      | 2     | Unicode Characters          |
    | **Boolean**                    | bool    | Boolean   | 1     | True / False                |

  - Non-Primitive Types
    - String
    - Array
    - Enum
    - Class

  

- Overflowing

  - 데이터 타입의 범위를 벗어남

  ```
  byte number = 255;
  number = number + 1;	// 0
  ```

  - `checked` 사용

  ```csharp
  checked
  {
  	byte number = 255;
  	number = number + 1;
  }	// 예외 발생
  ```

  - 실제로 많이 일어나진 않음

  

- Scope

  - 해당 블럭과 자식 블럭에는 값을 가져올 수 있지만, 스코프를 벗어날 경우 컴파일 에러가 발생한다.

  ```
  {
  	byte a = 1;
  	{
  		byte b = 2;
  		{
  			byte c = 3;
  		}
  	}
  }
  ```




- Type Conversion

  - Implicit Type Conversion

    ```csharp
    byte b = 1;	// 00000001
    int i = b;	// 00000000 0000000 00000000 00000001
    ```

  - Casting

    ```csharp
    int i = 1;
    byte b = i;		// won't compile
    byte b = (byte)i;	// casting
    ```

    ```csharp
    float f = 1.0f
    int i = (int)f;		// casting
    ```

  - Non-compatible types

    ```csharp
    string s = "1";
    int i = (int)s;		// won't compile
    ```

    ```csharp
    string s = "1";
    int i = Convert.ToInt32(s);	// 32bit의 int로 변환
    int j = int.Parse(s);	// int, float, boolean, long의 타입들은 Parse함수를 통해 숫자로 변환할 수 있다.
    ```

  - Convert

    - `ToByte()` `ToInt16()` `ToInt32()` `ToInt64()`
    
      

- Operators


  - Arithmetic Operators

    |                | Operator | Example |
    | :------------: | :------: | :-----: |
    |    **Add**     |    +     |  a + b  |
    |  **Subtract**  |    -     |  a - b  |
    |  **Multiply**  |    *     |  a * b  |
    |   **Divide**   |    /     |  a / b  |
    | **Reamainder** |    %     |  a % b  |
    | **Increment**  |    ++    |   a++   |
    | **Decrement**  |    --    |   a--   |

    ```csharp
    // Postfix Increment
    int a = 1;
    int b = a++;		// a = 2, b = 1
    
    // Prefix Increment
    int c = 1;
    int d = ++c;		// a = 2, b = 2
    ```

    


  - Comparison Operators

    |                              | Operator | Example |
    | :--------------------------: | :------: | :-----: |
    |          **Equal**           |    ==    | a == b  |
    |        **Not Equal**         |    !=    | a != b  |
    |       **Greater than**       |    >     |  a > b  |
    | **Greater than or equal to** |    >=    | a >= b  |
    |        **Less than**         |    <     |  a < b  |
    |  **Less than or equal to**   |    <=    | a <= b  |

    

  - Assignment Operators

    |                               | Operator | Example |  Same as  |
    | :---------------------------: | :------: | :-----: | :-------: |
    |        **Assignment**         |    =     |  a = 1  |           |
    |    **Addition assignment**    |    +=    | a += 3  | a = a + 3 |
    |  **Subtraction assignment**   |    -=    | a -= 3  | a = a - 3 |
    | **Multiplication assignment** |    *=    | a *= 3  | a = a * 3 |
    |    **Division assignment**    |    /=    | a /= 3  | a = a / 3 |

    

  - Logical Operators

    |         | Operator | Example  |
    | :-----: | :------: | :------: |
    | **And** |    &&    |  a && b  |
    | **Or**  |   \|\|   | a \|\| b |
    | **Not** |    !     |    !a    |

    

  - Bitwise Operators (for lower level)

    |         | Operator | Example |
    | :-----: | :------: | :-----: |
    | **And** |    &     |  a & b  |
    | **Or**  |    \|    | a \| b  |

- Comments

    - `//` for Single Line
    - `/* */` for multiple Lines
    - Comment는 최소화하자! (꼭 필요한 경우에만)
    - What 이 아닌 Why를 쓰자


- Demo
  - [Variables and Contants](./Demos/Chap02/VariablesAndConstants)
    - `cw` + `Tab` > Console.WirteLine(); 
    - `Ctrl` + `Click` > Object Browser
  - [Type Conversion](./Demos/Chap02/TypeConversion)
    - How to handle exception?
      - Use Try & Catch block
  - [Operators](./Demos/Chap02/Operators)



## 03. Non-Primitive Types

- Class

  - combine related variables or fields and functions together

  - Object: instance of a class

    ```csharp
    public class Person
    {
    	public string Name;
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
        /*
        public Add(int a, int b)
        {
            return a + b;
        }
        */
        
    }
    ```

    ** `public`: access modifier(액세스 한정자)로 클래스를 해당 앱의 어느곳에서라도 접근 할 수 있게 함 

  - Creating Objects

    ```csharp
    int number;
    var person = new Person();
    person.Name = "Tommy";
    person.Introduce();
    ```

    ** Garbage Collection: 메모리 관리의 기법으로 프로그램이 동적으로 할당했던 메모리중에서 필요 없게 된 영역을 해제하는 기능, C#은 CLR(Common Language Runtime)이 알아서 관리해준다

  - Static Modifier

    ```csharp
    public class Calculator
    {
    	public static int Add(int a, int b)
    	{
    		return a + b;
    	}
    }
    
    int result = Calculator.Add(1, 2)	// static을 사용할 경우 이렇게 바로 접근 가능
    ```

    - static modifier를 사용하지 않을 경우: 계산이 필요할 때 마다 메모리 할당
      - calc1, calc2, calc3 ... 이런식으로
    - static modifier를 사용할 경우: 클래스를 직접 불러서 적용

    

    



