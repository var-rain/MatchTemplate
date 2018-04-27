#pragma once
#ifndef __MATCH_IMAGE_H__
#define __MATCH_IMAGE_H__

#include "match_type.h"

#define EXPORT_DLL extern "C" __declspec(dllexport)

EXPORT_DLL int MatchImage(MatchResult &result);

#endif