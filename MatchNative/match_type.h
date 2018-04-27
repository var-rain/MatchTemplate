#pragma once
#ifndef __MATCH_TYPE_H__
#define __MATCH_TYPE_H__

// 匹配结果返回的结构体
//
// isMatch	是否匹配成功
// x		匹配到的图片位置的X坐标
// y		匹配到的图片位置的Y坐标
// width	匹配到的图片的宽度
// height	匹配到的图片的高度
typedef struct MatchResult
{
	char *source;
	char *target;
	bool isMatch;
	int x;
	int y;
	int width;
	int height;
};

#endif // __MATCH_TYPE_H__

