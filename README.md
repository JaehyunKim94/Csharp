# Learn C#

## 00. Learning Course

- [C# Basics for Beginners: Learn C# Fundamentals by Coding](https://www.udemy.com/course/csharp-tutorial-for-beginners/)



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
  
- [First Application Hello World](./CsharpFundamentals/HelloWorld)

  - 단축키

    | 단축키      | 기능                |
    | ----------- | ------------------- |
    | Ctrl + X    | 해당 줄 제거        |
    | Alt + Enter | 불필요한 Using 제거 |
    | Ctrl + F5   | 어플리케이션 실행   |

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

  

