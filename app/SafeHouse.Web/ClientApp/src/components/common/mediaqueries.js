export const Breakpoints = {
	small: 320,
	medium: 768,
	large: 1024,
	wide: 1366
};

const ScreenSize = {
	small: `@media only screen and (min-width: ${Breakpoints.small}px) and (max-width: ${Breakpoints.medium - 1}px)`,
	smallDown: `@media only screen and (max-width: ${Breakpoints.small - 1}px)`,
	medium: `@media only screen and (min-width: ${Breakpoints.medium}px) and (max-width: ${Breakpoints.large -1}px)`,
	mediumDown: `@media only screen and (max-width: ${Breakpoints.medium - 1}px)`,
	large: `@media only screen and (min-width: ${Breakpoints.large}px) and (max-width: ${Breakpoints.wide - 1}px)`,
	largeDown: `@media only screen and (max-width: ${Breakpoints.large - 1}px)`,
	wide: `@media only screen and (min-width: ${Breakpoints.wide}px)`,
};
export default ScreenSize;