#include "match_image.h"

EXPORT_DLL int MatchImage(MatchResult &result)
{
	result.x = 100;
	result.y = 100;
	result.width = 800;
	result.height = 480;
	result.isMatch = true;
	return 0;
}