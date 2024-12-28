"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express = require("express");
var handler = require("./class/httphandler");
var router = express.Router();
router.use(handler.checkSessionId);
router.get('/connection', handler.getConnection);
router.get('/offer', handler.getOffer);
router.get('/answer', handler.getAnswer);
router.get('/candidate', handler.getCandidate);
router.get('', handler.getAll);
router.put('', handler.createSession);
router.delete('', handler.deleteSession);
router.put('/connection', handler.createConnection);
router.delete('/connection', handler.deleteConnection);
router.post('/offer', handler.postOffer);
router.post('/answer', handler.postAnswer);
router.post('/candidate', handler.postCandidate);
exports.default = router;
//# sourceMappingURL=signaling.js.map