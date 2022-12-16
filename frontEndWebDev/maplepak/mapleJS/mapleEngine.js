/*Project MaplePak v0.0.0.1devEd
 *Date Created: 12/15/2022 12:52PM
 *Date Modified: 12/15/2022 12:53PM
 *Official Version: V0.0devEd
 *Project Purpose: MaplePak takes the stress out of styling and functionality by simply letting
 * 				   the user efficiently and quickly a website by just concentrating on the content.  
 * 				   However, will have to choose one's own colour scheme for own website. 
 *maplepak.js file purpose:MaplePak's JS is written in pure vanilla JS.  This is was deliberate because JS is not secure but more to the point loosely secure.  
 CSS was written in SCSS and compiled into css.  This is the main css file links are placed. 
Creator: William E Boswall  
*/
function createParagraph()
{
	const para = document.createElement('p');
	para.textContent = "You clicked the button!";
	document.body.appendChild(para);
}

const buttons = document.querySelectorAll('button');

for (const button of buttons) 
{
	button.addEventListener('click', createParagraph);
}