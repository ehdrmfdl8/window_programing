// File입출력.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
/*
파일 쓰기
ofstream 객체명("파일명");

파일 읽기

ifstream 객체명("파일명");

ifstream 객체명

객체명.open("파일명"); or 객체명.open("파일명", open모드 | open모드);
  ios::in			읽기만 가능한 형태로 파일 오픈
  ios::ate			파일을 오픈하면서 파일포인터를 끝부분으로 옮김
  ios::app			출력하는 데이터가 항상 파일의 끝에 기록
  ios::trunc		오픈하고자 하는 파일이 이미 있는경우, 기존의 파일을 삭제하고 다시 만듬
  ios::nocreate		file open 을 시도하지 않고 file의 존재 여부만 판단. file이 존재하지 않을 경우 에 러를 발생 (파일을 생성하지 않음)
  ios::noreplace	nocreate 와 반대. file이 존재하면 에러를 발생
  ios::binary		바이너리 파일 모드로 오픈
*/
#include "pch.h"
#include <fstream>
#include <iostream>
using namespace std;
#define MAX_SIZE 1000

char inputString[MAX_SIZE];

int  main() {
	// 파일 입력 (쓰기)
	ofstream outFile("output.txt");

	for (int i = 0; i < 10; i++) {

		outFile << i << endl;

	}

	outFile.close();

	//파일 출력 (읽기)

	ifstream inFile("output.txt");

	while (!inFile.eof()) {

		inFile.getline(inputString, 100);

		cout << inputString << endl;

	}

	inFile.close();

	return 0;
}