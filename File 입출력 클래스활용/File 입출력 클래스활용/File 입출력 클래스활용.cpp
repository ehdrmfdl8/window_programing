#include "pch.h"
#include <iostream>
#include <fstream>
#define MAX_SIZE 1000
using namespace std;
char line[MAX_SIZE];

class fileInput {

private:
	int lineNum;
	int messageNum;
public:
	void input(ifstream &infile, ofstream &outfile);
	void showLine();
};

void fileInput::input(ifstream &infile, ofstream &outfile) {

	while (!infile.eof()) {
		infile.getline(line, MAX_SIZE); //파일에 쓰여진 글 읽기
		lineNum++;

		if (!strncmp(line, "<__message__>", 13)) { //strncmp함수는 지정된 문저열 까지 같은지 판별해줌 같으면 0으로 반환
			messageNum++;
			outfile << line << endl;
		}
	}
}

void fileInput::showLine() {
	cout << endl;
	cout << "입력파일의 총 라인 수 : " << lineNum << endl;
	cout << "메세지 필드의 수 : " << messageNum << endl;
	cout << endl;
}

int  main() {
	ifstream infile("text.txt"); //파일 읽기
	ofstream outfile("output.txt"); //파일 쓰기
	fileInput fl;
	// 파일 스트림을 인자값으로 넘긴다

	fl.input(infile, outfile);

	fl.showLine();

	infile.close();

	outfile.close();
	ifstream infile2("output.txt");

	while (!infile2.eof()) {

		infile2.getline(line, MAX_SIZE);
		cout << line << endl;
	}
	infile.close();
	return 0;
}