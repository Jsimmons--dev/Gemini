﻿lda #$1
sta $0
lda #$100
sta $1
lda $1
sub #$1
sta $1
lda #$10
sta $4
lda $4
lda $0
lda $8