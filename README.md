# RosBridge-WinForm Integration

## 프로젝트 소개
이 프로젝트는 ROS(Robot Operating System)와 Windows Forms 애플리케이션을 연동하는 예제를 제공합니다. ROSBridge를 사용하여 WinForm 기반의 GUI에서 ROS 네트워크와 상호 작용할 수 있도록 설계되었습니다. 이를 통해 ROS 기반의 로봇 시스템을 Windows 환경에서 직관적으로 제어하고 모니터링할 수 있습니다.

## 주요 특징
- **ROSBridge 연결**: WinForm 애플리케이션에서 ROSBridge 서버에 연결하여 ROS 네트워크와 통신합니다.
- **토픽 관리**: ROS 토픽을 구독하고 발행하여 데이터를 교환할 수 있습니다.
- **사용자 인터페이스**: 사용자 친화적인 인터페이스를 통해 ROS 시스템을 쉽게 제어할 수 있습니다.
- **실시간 데이터 시각화**: ROS 시스템에서 받은 데이터를 실시간으로 시각화합니다.

## 시작하기
이 섹션에서는 프로젝트를 시작하는 방법을 안내합니다.

### 필요 조건
- Microsoft Visual Studio
- .NET 8.0
- rosbridge-client-ros (1.8.0)
- ScottPlot.WinForms (4.1.70)
- ROSBridge 서버가 실행 중인 ROS 설치

### 설치 과정
1. GitHub에서 프로젝트를 클론합니다:
2. Visual Studio에서 `Rosbridge-Winform.sln` 파일을 열고 프로젝트를 빌드합니다.
3. 필요한 NuGet 패키지를 설치합니다.

## 사용 방법
예제 프로젝트를 실행한 후, ROSBridge 서버의 IP와 포트 번호를 입력하여 연결합니다. 그런 다음 ROS 토픽을 구독하거나 발행하여 ROS 시스템과 상호 작용할 수 있습니다.
새로운 프로젝트에 사용하시기 위해서는 NuGet에서 rosbridge-client-ros (1.8.0)을 다운받으시고 RosCommunication폴더를 포함하시면 될 것입니다.

## 기능
- ROSBridge 서버와의 연결
- ROS 토픽 구독 <!--및 발행-->
- Scottplot을 통한 실시간 데이터 시각화

## 라이선스
이 프로젝트는 https://github.com/siemens/ros-sharp 를 참고하였습니다. 라이선스는 https://github.com/siemens/ros-sharp 를 참고해주세요.
