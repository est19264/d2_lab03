/* 
 * File:   ADC.h
 * Author: diego
 * Comments: Librería ára el ADC
 * Revision history: 1/08/2021
 */

 
#ifndef XC_HEADER_TEMPLATE_H
#define	XC_HEADER_TEMPLATE_H

#pragma config FOSC = INTRC_NOCLKOUT
#include <xc.h> // include processor files - each processor file is guarded.  

//defino el prototipo de la funcion
void ADC_config(char frec); //tomara el valor que deseamos de la frecuencia

#endif	/* XC_HEADER_TEMPLATE_H */